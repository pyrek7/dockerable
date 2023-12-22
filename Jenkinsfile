pipeline {
    agent any
    environment {
    DOCKERHUB_CREDENTIALS = credentials('azurecr')
  }
    stages {
        stage('Build image') {
            steps {
                 sh 'docker build -t pawelfiderek/dockerable .'
            }
        }
        
    }
}