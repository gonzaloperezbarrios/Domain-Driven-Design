# Net Framework 4.6.1

> Ejemplo básico “Hola Mundo”  implementando en la arquitectura
> Domain-Driven-Design (DDD)

## Instalar, capa: 1-Presentation

 - nuget 	
	 - unity 	
	 - unity.mvc

## Capas:

**1-Presentation**

 - asp.mvc
	 - 	Reference		
		 - Application
		- Infrastructure
		- 	Transversal	
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
	 		
**5-Transversal**	
 - domain.entities
