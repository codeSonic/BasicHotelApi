pipeline{

	agent { label 'master' }

	stages{
		stage('Build'){
			steps{
				echo "Building application"
				sh 'dotnet --version'
			}
		}
		stage('Test'){
			steps{
				echo "Running test cases"
			}
		}
	}
}