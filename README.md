![icon](http://i.imgur.com/0wQbb8q.png)

# Ocean SQL Profiler #
Cross-platform SQL profiler for PostgreSQL 9.3+. View your queries and functions being run in real-time in a simple to use GUI.

![screenshot](http://i.imgur.com/oFqnQYn.jpg "Screenshot on Windows 10")

### Features ###

* View your PostgresSQL functions and queries being executed in real-time GUI
* ...more to come! Feel free to contribute. Look below for more info.

### Setup Postgres Statement Log ###
* Locate where your PostgreSQL configuration files are
* Edit your postgresql.conf file with the following:
````
log_directory = 'pg_log'                    
log_filename = 'postgresql-commands.log
log_statement = 'all'
logging_collector = on
````
* Restart PostgreSQL
* Find where the pg_log directory is and where the newly made 'commands' LOG file has been created
* If examining a log on a remote server, virtual machine, vagrant/docker install you will need to mount the log file locally and then select it as a local file.
* Begin using the monitoring tool!

### Building on Windows ###

This should run on Visual Studio 2015+ and build without any problems.

### Building on Linux ###

* Install Mono libraries

````
sudo su
apt-get install mono-complete mono-xbuild
````

* Clone the project, cd into the working directory, and build it:

````
xbuild /p:TargetFrameworkVersion="v4.5" /p:Configuration=Release /p:DebugSymbols=False Ocean.csproj
````

And here it is running on Ubuntu 16.04 Desktop:
![screenshot_linux](http://i.imgur.com/dGJAuUl.jpg)

### Building on MacOS ###

I haven't tried yet! Help me clarify the documentation, if you can. This should build perfectly fine using the Mono build tools. Learn more about Mono's xbuild tool, equivalent to Microsoft's msbuild tool, here:

http://www.mono-project.com/docs/tools+libraries/tools/xbuild/

### Contributing ###

This is a small project that I hope will grow over time with more contributers. If you'd like to help improve this and turn it into a full application or just add some new features --please feel free to submit a pull request.

#### Want to help? Wondering where to start? Here's what I'd like to add in coming releases ####

* Examine pg_stats_statements to see what further information could be integrated into Ocean
* Examine pg_stats to see what further information could be integrated into Ocean
* Examine pg_log directory and all *.logs beneath it to see if any data can be aggregated and integrated into Ocean
* Examine pg_top and see if any data can be exported, aggregated, and integrated into Ocean
* Research and see if the EXPLAIN/ANALYZE command could be used to get further details about a query and aggregate the data into Ocean
* How to calculate duration of queries/functions being run in DB
* Provide searching, filtering, sorting features to the Ocean's main ListView widget containing the log data
* Better copy/paste functionality
* Better looking action toolbar with more commands and icons attached to text buttons
* Rotate Postgres logs and find a more efficient way to stream data out of logs than what is currently being used
* More menu options and actions
* Wizard to help setup a target PostgreSQL installation with the right config file changes so that the SQL Profiler will be able to function with less manual configuration changes by the user
* Create and manage cross-platform executables so that people don't have to build Ocean themselves, if they don't want too
* Create a github.io website for Ocean SQL Profiler
* ...and more! Feel free to add to this list if I've missed something.

Thanks!
