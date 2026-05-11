
<img width="1686" height="763" alt="image" src="https://github.com/user-attachments/assets/56b42123-9094-4895-8dae-4247fcda25a2" />


<img width="1894" height="690" alt="image" src="https://github.com/user-attachments/assets/1a0bcfab-e0fd-4cc1-a7d8-69817b65d837" />

<img width="1170" height="757" alt="image" src="https://github.com/user-attachments/assets/9030c2ec-dfc0-437d-b522-4ebd805ddb13" />

<img width="673" height="784" alt="image" src="https://github.com/user-attachments/assets/733c3c95-d745-4a0c-93b4-c7408810f55c" />






# 📧 AI Email Summarizer Agent

An AI-powered email summarization web application that converts long emails into short, clear, and actionable bullet points using OpenAI and n8n workflows.

Built with ASP.NET MVC, n8n, OpenAI API, AJAX, and a modern futuristic dark UI.

---

## 🚀 Features

- 🤖 AI-generated email summaries
- 📌 Converts long emails into quick bullet points
- ⚡ Real-time summarization using AJAX
- 🌐 ASP.NET MVC frontend integration
- 🔗 n8n webhook automation
- 🎨 Premium futuristic dark UI
- 📋 One-click copy summary button
- 📱 Responsive modern design
- 🔄 Live loading animation
- 🧠 Smart AI text processing

---

## 🛠️ Technologies Used

- ASP.NET MVC
- C#
- n8n
- OpenAI API
- AJAX
- Bootstrap 5
- HTML5
- CSS3
- JavaScript

---

## 📂 Project Structure

```bash
AI-Email-Summarizer/
│
├── Controllers/
├── Views/
├── wwwroot/
├── Models/
├── n8n-workflow/
└── README.md
```

---

## ⚙️ How It Works

1. User pastes a long email into the textarea
2. ASP.NET MVC sends the email to the n8n webhook
3. n8n processes the request using OpenAI
4. OpenAI generates a summarized version
5. The summary is returned as bullet points
6. The frontend displays the result instantly

---

## 🔗 Example API Request

### POST Request

```json
{
  "email": "Hello team, today we discussed the SmartMail project progress, upcoming deadlines, UI fixes, backend APIs, security checks, and QA testing plans."
}
```

---

## ✅ Example Response

```text
• SmartMail project progress discussed
• Deadline scheduled for next Friday
• UI team should fix dashboard bugs
• Backend APIs are completed
• Security checks required before deployment
• QA testing starts tomorrow
```

---

## 📸 Workflow Overview

```text
User Email
    ↓
ASP.NET MVC
    ↓
n8n Webhook
    ↓
OpenAI Processing
    ↓
AI Summary Generation
    ↓
Frontend Display
```

---

## ▶️ Running the Project

### 1. Clone the repository

```bash
git clone https://github.com/your-username/AI-Email-Summarizer.git
```

---

### 2. Open the project

Open the solution using:

```bash
Visual Studio
```

---

### 3. Start n8n

```bash
n8n start
```

---

### 4. Activate the workflow

Make sure the webhook workflow is active in n8n.

---

### 5. Run the ASP.NET MVC project

Press:

```bash
CTRL + F5
```


--

## 👨‍💻 Author

Ahmed Dabish

- GitHub: https://github.com/AhmedDabish
- LinkedIn: https://www.linkedin.com/in/Ahmed-Dabish

---

## ⭐ Support

If you like this project, give it a star on GitHub ⭐
