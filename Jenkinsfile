pipeline{

	agent {
        docker { image 'mcr.microsoft.com/dotnet/core/sdk:2.1' }
    }

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