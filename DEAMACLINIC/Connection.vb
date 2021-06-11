Imports System.Data.SqlClient

'//  AUTHUR :  FAYEMI OLADELE SUNDAY
'//  Phone:    07082110394, 07064659524
'//  Email:   fasunosoft@gmail.com
'//  

Module Connection
    Public ExecuteQuery As String
    Public query As String
    'Public update As String

    Public con As New SqlConnection("Server=FASUNO; initial catalog=MDHMEDXPRO; Trusted_Connection=true")


    '============NOTES ON CONNECTION=================
    'The  below con string actually worked after many errors
    'The problem was actually from the SQL server management studio, I created a user as below
    'set the authentication to "SQL SERVER AUTHENTICATION" instead windowds authentication
    'Let the default database be PROMEDDB
    'Go to User mapping, Select PROMED, below it set the "Role Membership by checking 1. db_owner 2. Public
    'Also ensure that you enable TCP/IP on SQL server configuration manager and make it start automatically

    'Public con As New SqlConnection("Server=192.168.10.1; initial catalog=SUPREMEDB; User Id=Sunday; Password=P@55w")
    '
    Public cmd As New SqlClient.SqlCommand
    Public adapt As New SqlDataAdapter
    'Public Executequery As String
End Module
