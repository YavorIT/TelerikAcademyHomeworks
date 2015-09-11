
/*
                        Problem 10. Extract text from XML

    Write a program that extracts from given XML file all the text without the tags.
*/

using System;
using System.Xml;

class ExtractTextFromXML
{
    static void ExractXmlStudents()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(@"..\..\Files\inputXML.xml");
        
        foreach (XmlNode node in doc.DocumentElement)
        {
            PrintStudentInfo(node);
            PrintStudentInterests(node);
        }
    }

    static void PrintStudentInfo(XmlNode node)
    {
        Console.WriteLine("\tStudent");
        Console.WriteLine("Name: {0}", node["name"].InnerText);
        Console.WriteLine("Age: {0}", node["age"].InnerText);
    }

    static void PrintStudentInterests(XmlNode node)
    {
        int count = 1;

        Console.WriteLine("\tInterests");
        foreach (XmlNode childNode in node["interests"])
        {
            Console.WriteLine("{0}. {1}", count, childNode.InnerText);
            count++;
        }
    }

    static void Main()
    {
        ExractXmlStudents();
    }
}