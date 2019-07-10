pipeline{

	agent {
    kubernetes {
      label 'dynamicslavek8s'
      defaultContainer 'jnlp'
      yaml """
apiVersion: v1
kind: Pod
metadata:
  labels:
    podtype: jenkinsdynamimcslave
spec:
  containers:
  - name: dynamicslave
    image: mcr.microsoft.com/dotnet/core/sdk:2.1
    command:
    - cat
    tty: true
"""
    }
  }

	stages{
		stage('Build'){
			steps{
			container('dynamicslave') {
					echo "Building application"
					sh 'dotnet --version'
				}
			}
		}
		stage('Test'){
			steps{
			container('dynamicslave') {
					echo "Running test cases"
				}
			}
		}
	}
}