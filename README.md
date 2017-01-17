# Ocean SQL Profiler #
Cross-platform SQL profiler for PostgreSQL 9.3+. View your queries and functions being run in real-time in a simple to use GUI.

### Setup Postgres Statement Log ###

* Edit your postgresql.conf file with the following:
````
log_directory = 'pg_log'                    
log_filename = 'postgresql-commands.log
log_statement = 'all'
logging_collector = on
````
* Restart PostgreSQL
* Find where pg_log and the newly made LOG file has been created
* If examing a log on a remote server, virtual machine, vagrant/docker install you will need to mount the log file locally and then select it as a local file.
* Begin using the monitoring tool!

### Contributing ###

This is a small project for me. If you'd like to help improve this and turn it into a full application or just add some new features --please feel free to submit a pull request.

Thanks!
