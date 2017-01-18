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

### Building on MacOS or Linux ###

This should build perfectly fine using the Mono build tools. Learn more about Mono's xbuild tool, equivalent to Microsoft's msbuild tool, here:

http://www.mono-project.com/docs/tools+libraries/tools/xbuild/

### Contributing ###

This is a small project for me. If you'd like to help improve this and turn it into a full application or just add some new features --please feel free to submit a pull request.

Thanks!
