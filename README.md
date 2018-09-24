# NoxGaming SAIEditor
 Basic SmartScript (SAI) editor for creatures.

# Goal
Offer an easy-to-use, user friendly platform for unexperienced users to start working on SAI and learning how the system works from ground zero.

Although the application may make it way easier to handle queries, it is always encouraged to search and learn how to write queries on your own.

# System Requirements
  1. .NET Framework 4.6.1 or newest
  1. MySQL 6.10 or newest
  1. A TrinityCore database installation (check TrinityCore's repository or ours [NoxGaming](https://github.com/NoxGaming/TrinityCore))
  
  # Installation
  Install the required software and set up the world database that will be used by the application to get SmartAI entries from, compile the code and run it.
  
  # Usage
  
  ## 1. Log in to your database
  ![ImageDB](https://i.imgur.com/pZanHxy.png)
  
  ## 2. Look up the creature you are working with
  ![ImageCR](https://i.imgur.com/cjKtuzP.png)
  
  ## 3. Fill the data in order to generate your SQL
  ![ImageBuilder](https://i.imgur.com/OqRKfZa.png)
  
  The system will offer you help regarding each of the fields you must go through in order to build your query.
  Currently the application only supports building basic "In Combat" events.
  
  Hit "Generate" once you are done - it will build your SQL query and stash it away for later use. Once you are done writing your queries,
  you may hit "Export" in order to print them all for you. Doing so will clear the stash, so use it carefully, you won't be able to return
  to editing in case you find there are more queries for you to build.
  
  ## 4. Export your Queries
  
  Hitting "Export" will display the queries you previously build.
  ![ImageExport](https://i.imgur.com/kjxjT2X.png)
  
  In this window, you may choose to export them to a file, which will conveniently create a file using the TrinityCore SQL naming convention
  (YYYY_MM_DD_NN_world_custom.sql) - note the addition of the "custom" tag to help you diferentiate your own work.
  
  You may also copy the content to your clipboard and apply it to your database manually.
  
  # DISCLAIMER
  This application has bugs. It is unfinished and will likely be in an unfinished, constantly mutable stage for a long while.
  Not every exception is handled, it may and will crash if you don't use the expected values (TO-DO).
  
  # Thanks
  Special thanks to [@PatricNox](https://github.com/PatricNox) for being just as awesome as he is and being an exceptional friend-for-all-times, workmate and leader.
