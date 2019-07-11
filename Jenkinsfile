pipeline{

	agent none

	stages{
		stage('Build'){
		
			agent {
				kubernetes {
				  cloud 'kubernetes-local'
				  label 'dynamicslavek8sdotnetbuild'
				  defaultContainer 'jnlp'
				  yaml """
apiVersion: v1
kind: Pod
metadata:
  labels:
  podtype: jenkinsdynamimcslavedotnetbuild
spec:
  containers:
  - name: dynamicslavedotnetbuild
    image: mcr.microsoft.com/dotnet/core/sdk:2.1
    command:
    - cat
    tty: true
"""
				}
			}
			steps{
				
				echo "Building application"
				sh 'dotnet --version'
				sh 'sleep 1m'			
			}
		}

		stage('Docker build image'){
			agent {
				kubernetes {
				  cloud 'kubernetes-qa'
				  label 'dynamicslavek8sdockerbuild'
				  defaultContainer 'jnlp'
				  yaml """
apiVersion: v1
kind: Pod
metadata:
  labels:
  podtype: jenkinsdynamimcslavedockerbuild
spec:
  containers:
  - name: dynamicslavedockerbuild
    image: docker
    command:
    - cat
    tty: true
"""
				}
			}
			steps{
				sh 'docker --version'
				sh 'sleep 10m'
			}
		}
	}
}