
/*
                Problem 12. Parse URL

    Write a program that parses an URL address given in the format: 
    [protocol]://[server]/[resource] and extracts from it
    the [protocol], [server] and [resource] elements.

    Example:

    http://telerikacademy.com/Courses/Courses/Details/212	
   
    [protocol] = http 
    [server] = telerikacademy.com 
    [resource] = /Courses/Courses/Details/212
*/

// This can be done with Regex formats like in project 18 but i decided to leave this implementation.

using System;

class ParseURL
{
    const int numberOfSlashesAndColon = 3;

    static string GetProtocol(string URL)
    {
        return URL.Substring(0, URL.IndexOf(':'));
    }

    static string GetServer (string URL, string protocol)
    {
        return URL.Substring(protocol.Length + numberOfSlashesAndColon, URL.IndexOf('/', protocol.Length + numberOfSlashesAndColon + 1) - protocol.Length - numberOfSlashesAndColon);
    }

    static string GetResource(string URL, string protocol, string server)
    {

        return URL.Substring(protocol.Length + numberOfSlashesAndColon + server.Length);
    }

    static void PrintResult (string protocol, string server, string resource)
    {
        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }

    static void Main()
    {
        Console.Write("Enter the URL: ");
        string URL = Console.ReadLine();

        string protocol;
        string server;
        string resource;

        protocol = GetProtocol(URL);
        server = GetServer(URL, protocol);
        resource = GetResource(URL, protocol, server);

        PrintResult(protocol, server, resource);
    }
}