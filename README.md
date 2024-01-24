Summary of the project <br/>

This application empowers the animal clinic staff to effectively organize the queue of sick pets by considering severity, continuity, and time. The medical team can effortlessly enter the pet's name, sick name, and severity, continuity, and time indicators. Subsequently, the system automatically reorders the queue, prioritizing pets with higher scores based on the calculated severity, continuity, and time factors. This ensures that the veterinarian attends to the patient (pet) with the highest calculated score first.

Motivation <br/>
The veterinary industry has experienced significant growth since the turn of the millennium. Having worked part-time as an ecommerce analyst for several years in a clinic chain, I've observed that the medical staff operates more efficiently when the systems utilize a Priority Queue as a collection class to manage the insertion of more serious cases. The Priority Queue is structured based on Linked Lists to store data but employs distinct algorithms for handling enqueue and dequeue operations.
It was my 2022 school project on data structures, and I start to revamp the whole by simplifying the entire project using C#. I incorporated various software patterns, such as Factory and Decorator, to streamline and enhance the project.

Project Structure<br/>
The structure can be divided into 3 parts
1.	Base Class
a.	LinkedList
b.	 Priority Queue
2.	Clinic
a.	Pet Class
b.	Sickness Class
3.	State (Factory Pattern to switch between the Action State using IActionFty class)
a.	Action : To control the streams which Factory of Display, Input or Move being created
b.	Display
c.	Input
d.	Move
4.	Validator (Decorator Class to recycle method of validation for userInput)
a.	EmptyValidator
b.	IntegerValidator
c.	StringValidator
d.	ValidatorClass (Abstract Class)
Extendibility
In future, the project will extend with following functionality
1.	Types and instances of customers, such as Customer Type and the Customer class representing the pet parent.
2.	The Invoicing class, dedicated to handling invoicing operations.
3.	Implementation of a Strategy pattern, utilizing interfaces to enable seamless switching among Calculation Strategy options, catering to both VIP and non-VIP members.
4.	A sorting algorithm class that inherits from the LinkedList Class, offering dynamic control over the algorithm choice based on user input actions.
