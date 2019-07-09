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
    image: jenkins/jnlp-slave
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