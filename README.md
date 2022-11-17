Lego Set Tracker

This program display manually entered or imported Lego Set Details to display in the console application.

Upon starting the prorgram you will be presented with 3 choices:  
1) Manually enter set.
    -When manually entering a set you will be presented with 6 different items to input information
        SetID:      The numerical id number of the set
        Title:      The title of the set eg. Darth Vader Helmet, Ecto 1, etc. 
        Theme:      The theme or Franchise of the set eg. Star Wars, Ghostbusters, etc. 
        Pieces:     The number of pieces the set contains. 
        MiniFigs:   How many mini figures if any are in the set. 
        Complete:   Has the set been built or completed. 
    
2) Import set.
    -When importing the set the program imports from a JSON file.  The JSON file needs to be placed in the project file at this path /LegoSetTracker/LegoSetTracker/bin/Debug/net7.0/JSONIMPORT
    A folder named JSONIMPORT is included in this repository that you can copy and past into the path.  In it, contains an example set import file. 
    
    -Below is the structure required for JSON files. 
        {
        "SetId": 75327,
        "Title": "Luke Skywalker Helmet",
        "Theme": "Star Wars",
        "Pieces": 675,
        "MiniFigs": 0,
        "Complete": "Yes"
        },
3) exit program.
    -Option 3 simply exists the program. 


Thank you for using Lego Set Tracker and we hope to implement more features in the near future. 
