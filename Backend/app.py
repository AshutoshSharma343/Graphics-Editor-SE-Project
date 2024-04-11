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
        additional_message = "Return result which category of influencer is needed. The categories are Entertainment, Education, Gaming, Art, Finiance, Fitness and Others. Return only category name. The result must be only one category name from the above mentioned categories. if the category seems different then you may give Others as Category also\n"

        prompt_message = content + additional_message

        response = openai.Completion.create(
            model="gpt-3.5-turbo-instruct",
            prompt=prompt_message,
            max_tokens=50,
            stop=None
        )
        
        # Parse the response from OpenAI to determine the category
        category = "Other"  # Default to "Other" if not determinable
        # Include your logic here to determine the category from the response
        category = response['choices'][0]['text'].strip()  # Assuming OpenAI's response contains the category name

        return jsonify({"category": category}), 200
    
    except Exception as e:
        return jsonify({"error": str(e)}), 500

if __name__ == '__main__':
    app.run(debug=True)