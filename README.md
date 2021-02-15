# Porpoise CMS

A .NET 5 Container First CMS designed for high scalability, persistence and speed.

The general idea - 
* Persisted 'Data' folder containing Views & JSON data files
* JSON data maps route e.g. "/home" to a view
* Front end containers copy views locally, memory cache JSON data, hook up routes
* CMS can edit JSON files / views and containers will update themselves

This should allow you to have many front end sites working at scale on a container system such as Docker Swarm or Kubernetes.

Things to consider for future - 
* API
* Blocks / Data Pickers
* Indexing
* HTML helpers


