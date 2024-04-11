from flask import Flask, request, jsonify
from googleapiclient.discovery import build
import psycopg2
import openai
from flask_cors import CORS

# API key obtained from Google Cloud Platform Console
#API_KEY = 'AIzaSyBRDi28VH99y_Xd5K_jb5MXiSt_LvtgQBY'

openai.api_key = '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'

app = Flask(__name__)
CORS(app)

@app.route('/')
def index():
    return "Hello, World!"

@app.route('/prompt', methods=['POST'])
def categorize_prompt():
    content = request.json['content']
    
    try:
        additional_message = "Give an Elaborate, Informative and Helpful answer for the given prompt :  \n"

        end_message = " the response should be of 550 words and the given response should be point-wise"

        prompt_message = content + additional_message + end_message


        response = openai.Completion.create(
            model="gpt-3.5-turbo-instruct",
            prompt=prompt_message,
            max_tokens=550,
            stop=None
        )
        
        # Include your logic here to retrieve all generated text responses
        responses = [choice['text'].strip() for choice in response['choices']]
        
        # Create a formatted string with bullet points or numbered lists
        formatted_text = ""
        for i, choice in enumerate(responses, start=1):
            formatted_text += f"{i}. {choice}"

        response_data = {"category": formatted_text}

        # Return the response as JSON
        return jsonify(response_data), 200
    
    except Exception as e:
        return jsonify({"error": str(e)}), 500

if __name__ == '__main__':
    app.run(debug=True)