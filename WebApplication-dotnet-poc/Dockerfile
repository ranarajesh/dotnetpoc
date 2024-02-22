# Use the official .NET Core SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Set the working directory in the container
WORKDIR /dotnetpoc

# Copy the project files to the working directory
COPY . ./  

# Restore NuGet packages
RUN dotnet restore

# Expose the port your app will run on
# EXPOSE 5044

# Start the application
#CMD ["dotnet", "watch", "run", "--urls", "http://0.0.0.0:5000"]
CMD ["dotnet", "run"]