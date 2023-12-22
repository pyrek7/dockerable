pipeline {
    agent any
    environment {
    DOCKERHUB_CREDENTIALS = credentials('azurecr')
    dotnet = '"C:\\Program Files\\dotnet\\dotnet.exe"'
  }
    stages {
        stage('Build code') {
            steps {
                 bat "${dotnet} build"
            }
        }
         stage('Run code') {
            steps {
                 bat "${dotnet} run"
            }
        }
         stage('Clean code') {
            steps {
                 bat "${dotnet} clean"
            }
        }
        
    }
}