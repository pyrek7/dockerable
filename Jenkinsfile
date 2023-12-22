pipeline {
    agent any
    def app
    environment {
    DOCKERHUB_CREDENTIALS = credentials('azurecr')
    dotnet = '"C:\\Program Files\\dotnet\\dotnet.exe"'
  }
    stages {
        stage('Build image') {
            steps {
                 app = docker.build("pawfidreg.azurecr.io/pablo/hellonode")
            }
        }
        
        
    }
}
