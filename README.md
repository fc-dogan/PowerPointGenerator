# PowerPoint Generator

####  MVC application that users can use to aid them in generating a PowerPoint slide.  , July 2020

#### By _**Fatma C. Dogan**_

## Description
This is an application to give the user suggestions of images to use from the internet, based on the contents of the information they are using for the slide.

## Specification user stories
* A user is able to fill in the form title and content and navigate to the edit page.
* A user is able to edit their content input and able to bold selected words.
* A user is able to navigate the image suggestion area. The area has images searched through Bing Web Search API with words in the title and bold words in the content area.
* A user is able to navigate to the PowerPoint slide that has title, content, and selected images.

## Setup/Installation Requirements

#### Prerequisites

```.Net SDK```
* Download the .NET SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

#### Installing
1. Clone this repository
    * _In Terminal:_

       * Navigate to where you want this application to be saved, i.e.:
    ```cd desktop```
      * Clone the file from GitHub with HTTPS
    ```git clone https://github.com/fc-dogan/PowerPointGenerator ```
      * Open file in your preferred text editor
    ```cd PowerPointGenerator ```

    * _Download Manually:_
    
      * Navigate to https://github.com/fc-dogan/PowerPointGenerator
      * Click the green "Clone or Download" button.
      * Click "Download ZIP".
      * Click downloaded file to unzip.
      * Open folder called "PowerPointGenerator".

2. Restore all dependencies
   * Enter the following code in the command line to install all necessary dependencies to the project.
     * ```dotnet restore```
3. Linking API key
   * This application requires an API key to run properly.
      * Get a personal API key from </br>
         https://www.microsoft.com/en-us/bing/apis/bing-web-search-api
    * Create a `App.config` file in the root directory or the project. Obtain your own API key in .env file.</br>
      ```
      <configuration>
        <appSettings>
          <add key="Key" value="enter your API Key here" />
        </appSettings>
      </configuration>
      ```
4. Run the program
    * ``` dotnet run```
    * Note: To exit, simply press ```Ctrl + C```
5. Open the local hosted server
  ``` http://localhost:5001 ```

## Known Bugs

_No known bugs at this time._


## Technologies Used

* C#
* .Net 5.0
* ASP.NET MVC
* jQuery
* VS Code
* CSS
* Bootstrap

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Fatma C. Dogan_**