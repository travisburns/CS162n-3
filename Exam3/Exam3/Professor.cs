/* 
 Assume that you've been asked to write a series of programs for a community college. One of the "components" in the college's system is a Professor. A Professor has an Lnumber, a first name, a last name and a department.

Design a class that represents a Professor. Document your class by creating a class diagram in Visio or Visual Studio or by listing the name of the class, the attributes or characteristics of the class and the methods of behaviors of the class. Don't forget things like getters and setters (and reasonable error handling in at least one of the setters) or properties, constructors and ToString.

Implement the class in C#. 

Test the class in a C# console application. 
 
 */


/* 
    //Input

    //Lnumber (string)
    //FirstName (string)
    //LastName (string)
    //Department (string)

   //Process

    //Create a Professor object with the provided Lnumber, FirstName, LastName, and Department.
    //Validate the input values (e.g., ensure Lnumber is not null or empty).
    //Set the attribute values using the appropriate setter methods or properties.

   //Output

    //A Professor object with the specified Lnumber, FirstName, LastName, and Department.
    //Error messages or exceptions if any input validation fails. 

 */
/* 
 Assume that you've been asked to write a series of programs for a community college. One of the "components" in the college's system is a Professor. A Professor has an Lnumber, a first name, a last name and a department.

Design a class that represents a Professor. Document your class by creating a class diagram in Visio or Visual Studio or by listing the name of the class, the attributes or characteristics of the class and the methods of behaviors of the class. Don't forget things like getters and setters (and reasonable error handling in at least one of the setters) or properties, constructors and ToString.

Implement the class in C#. 

Test the class in a C# console application. 
 
 */


/* 
    //Input

    //Lnumber -string
    //FirstName -string
    //LastName -string
    //Department -string

   //Process

    //Create a Professor object with the provided Lnumber, FirstName, LastName, and Department.
    //Validate the input values by ensuring Lnumber is not null or empty.
    //Set the attribute values using the appropriate setter methods or properties.

   //Output

    //A Professor object with the specified Lnumber, FirstName, LastName, and Department.
    //Error messages or exceptions if any input validation fails. 

 */

using System;

public class Professor
{

    private string _lNumber;
    private string _firstName;
    private string _lastName;
    private string _department;

  
    public string LNumber
    {
        get { return _lNumber; }
        set { _lNumber = value; }
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public string Department
    {
        get { return _department; }
        set { _department = value; }
    }

    
    public Professor(string lNumber, string firstName, string lastName, string department)
    {
        _lNumber = lNumber;
        _firstName = firstName;
        _lastName = lastName;
        _department = department;
    }

    
    public override string ToString()
    {
        return $"{_firstName} {_lastName} - {_lNumber} - {_department}";
    }
}