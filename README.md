# Domain-Driven-Design (DDD) / Net Framework 4.7.1

> Ejemplo básico “CRUD usando EntityFramework”  implementando en la arquitectura Domain-Driven-Design (DDD)

## Instalar, capa: 1-Presentation
 - nuget 	
	 - unity 	
	 - unity.mvc
	 - EntityFramework
	 - AutoMapper
	 
## Instalar, capa: 4-Infrastructure	 
 - nuget 	
	 - EntityFramework 	
 - Package Manager Console
	- enable-migrations
	- update-database
	- update-database -force

## Capas:

**1-Presentation**

 - asp.mvc
	 - 	Reference		
		 - Application
		- Infrastructure
		- Transversal	
	 - App_Start			
		 - UnityConfig.cs				
			 - `RegisterTypes(IUnityContainer container) --> ennable -> container.LoadConfiguration();`
			
		 - WebUnityConfig.config
				
			 - Example: dependency injection		 
			<register type="Name namespace + interface, nameApplicationLayer"
					  apTo="Name namespace + class, nameApplicationLayer" /
				
**2-Application**
 - Reference 		
	 - Domain 		
	 - Transversal	
 - 	application.services
	- ClassService
	- IClassService
	 
**3-Domain**
 - domain.services 
	 - ClassService 
	 - InterfaceService
 - repositories.contracts
	- InterfaceService
	
**4-Infrastructure**
 - Reference 		
	 - Domain 		
	 - Transversal
 - repositories
	- class implemt repositories.contracts.InterfaceService
- persistence
	- EntityFramework
- Migrations
	 		
**5-Transversal**	
 - domain.entities
 
## Documentación de apoyo 

> Guía para EntityFramework Code First > https://www.youtube.com/watch?v=IKlmroHxDNc


> Guía DDD
> http://www.zankavtaskin.com/2013/09/applied-domain-driven-design-ddd-part-1.html

>Arquitectura 
> ![DDD](https://i.stack.imgur.com/mkEyv.jpg)