# Randomize-String-Digits
This will randomize all numbers in a given text

I was working on a webscraper/webcrawler to pull some data from a certain website when I noticed that they are blocking some of my webbrowser requests.
I realized that if I change my User Agent, my requests won't get blocked. Problem is, I'm too lazy to compile a list of different User Agents.

After some thought, I figured, why not I'll just keep like 10 different User Agents, and then randomize their versions?

And so I came up with this project. This is also particularly useful if you want to generate strings with different numeric components.

Example screen below:
![code-3](https://user-images.githubusercontent.com/5296677/76676888-e8355b00-6602-11ea-97fe-9bf836213cc9.png)

The logic uses 2 important methods only:
1. Function to generate random numbers each time it's called
![code-2](https://user-images.githubusercontent.com/5296677/76676884-dd7ac600-6602-11ea-92e9-6dd0471b68db.png)

2. Function that will do the replacing of numbers
![code-1](https://user-images.githubusercontent.com/5296677/76676877-d358c780-6602-11ea-969f-4a4bcaf2af7b.png)

Feel free to improve the logic.

Thanks!
