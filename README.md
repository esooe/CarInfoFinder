🚗 Car Info Finder API - README
This project is a .NET Core 8 Web API built using Union Architecture (Clean Architecture) that allows users to select car makes, years, and vehicle types to retrieve available car models
 from the NHTSA database via public APIs.

It uses:

-.NET Core 8

-Union Architecture Pattern

-Docker containerization

-GitHub Actions CI/CD for deployment

-AWS Elastic Beanstalk hosting (Free Tier)


🛠️ Technologies Used

-Backend : C#, .NET 8, ASP.NET Core Web API

-Architecture : Union / Clean Architecture

-Containerization : Docker

-CI/CD : GitHub Actions

-Cloud Hosting : AWS Elastic Beanstalk


🔧 Step-by-Step Instructions to Run Locally 

1. Prerequisites
 Ensure you have the following installed:

  1-.NET 8 SDK
   
  2-Docker Desktop
  
  3-Git CLI or GUI
  

3. Clone the Repository
   use (https://github.com/esooe/CarInfoFinder.git) 

4. Build and Run with Docker
  Using docker-compose: docker-compose up --build
![image](https://github.com/user-attachments/assets/8668b9e0-e1a7-48da-bbc7-ee961a24ebc2)

The application will be available at: http://localhost:32771/swagger/index.html
![image](https://github.com/user-attachments/assets/af6edba2-7aad-4080-8749-2cd526dd129d)



☁️ Deployment to AWS Elastic Beanstalk

1. Create an AWS Account

2. Create IAM Access Key : To Create Access Key ID and Secret Access Key , Save these securely — we'll use them in GitHub Secrets.

3. Create Elastic Beanstalk Application
 
4. Configure GitHub Actions Workflow

5. Add Secrets to GitHub

6. Push to GitHub


✅ Accessing the Deployed API 
The application will be available at: http://carinfofinderapp-env.eba-f2phbshf.eu-north-1.elasticbeanstalk.com/swagger/index.html  

![image](https://github.com/user-attachments/assets/de1e785e-66c1-4f5f-a72f-47e001beb977)



