## Welcome ~!

Web Api to keep track of things i do, more like a logging system side project.
utilizes Repository with unit of work design patters

has authentication but it is there for fun, thought i wanted it but _nope!

**don't care about secrets** cause the API will live on my personal machine and will be only accessable via my local network.

for the API endpoints docs swagger has this covered just run it !

####  how to run:
clone it
and then 
``` docker-compose up ``` 
(it will take care of the secrets itsef)
###### dont forget these: 
1. **_kills all running containers_**
``` 
docker kill $(docker ps -q)
```
2. **_deletes all stopped containers_**
```
docker rm $(docker ps -a -q)
```
3. **_deletes all images_**
```
docker rmi $(docker images -q)
```

otherwise do to initilize and set the secrets :
	- need to be in the same directory as the API
```
 dotnet user-secrets init
 dotnet user-secrets set "SQLSERVER:User" "sa"
 dotnet user-secrets set "SQLSERVER:Pass" < whatever u want >
 dotnet user-secrets set "jwtKey" < whatever u want >
 dotnet user-secrets set "Kestrel:Certificates:Development:Password" "Crimz0n!" 
```

things todo:
- [ ] document it then link to it here
- [ ] setup more endpoints
- [ ] test
- [ ] github actions
- [ ] make the relations better (need to learn more~!)
- [ ] workflow diagram
- [ ] draw ... i forgot what's it called xD
- [ ] health endpoint
- [ ] images instead of strings ya fool!!
- [x] https for docker.
