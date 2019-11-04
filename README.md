# Augen.TechnicalTest

1. Design Pattern: Factory Method
		Benefit: Purpose of the Factory Pattern is managing and returning the object as required, help to initialize the object flexibly.

2. SOLID: 
  2.1. L (Liskov substitution principle)		
    Ex: 
      - In DeliveryBase, there're methods GetFactor, GetDeliveryCost which are overrided by delivery service types (Train, Aircraft, Motorbike) to get the cost by service type.
      - In DeliveryInfoBase, there's GenerateInfo is overrided by delivery service types to generate info of each service (MotorbikeDeliveryInfo, TrainDeliveryInfo, AircraftDeliveryInfo).
  2.2. D (Dependency inversion principle)
    Ex: 
      - In DeliveryController, action GetDeliveryCost get the cost for selected service via IDeliveryCostService with the implementation DeliveryCostService.GetDeliveryServiceCost()
      - IDeliveryInfoGenerateService with DeliveryInfoGenerateService.GenerateInfo to get the info by selected service.

3. Time summary:
  - Preparation: 4 hours
  - Coding: 7 hours (including tests)
  - Styling 30 minutes
  - Building and testing 30 minutes
  Grand total: 12 hours
