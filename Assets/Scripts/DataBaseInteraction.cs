using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Text;
using System.Security.Cryptography;

public class DataBaseInteraction : MonoBehaviour
{


    private string secretKey = "mySecretKey";

    
    private string ADD_TABLE_URL = "https://sukkarhala1.000webhostapp.com/AddTable.php?";
    private string ADD_PAYMENT_URL = "https://sukkarhala1.000webhostapp.com/AddPayment.php?";
    private string ADD_MENU_URL = "https://sukkarhala1.000webhostapp.com/AddMenu.php?";

    private string GET_TABLE_DATA_URL = "https://sukkarhala1.000webhostapp.com/GetTableData.php?";
    private string GET_PAYMENT_DATA_URL = "https://sukkarhala1.000webhostapp.com/GetPaymentData.php?";
    private string GET_MENU_DATA_URL = "https://sukkarhala1.000webhostapp.com/GetMenuData.php?";


    private string SHOW_ALL_TABLE_URL = "https://sukkarhala1.000webhostapp.com/SelectAllTable.php?";
    private string SHOW_ALL_PAYMENT_URL = "https://sukkarhala1.000webhostapp.com/SelectAllPayment.php?";
    private string SHOW_ALL_MENU_URL = "https://sukkarhala1.000webhostapp.com/SelectAllMenu.php?";


    private string GET_ATTRIBUTE_OF_ALL_TABLE_URL = "https://sukkarhala1.000webhostapp.com/GetAttributeTable.php?";
    private string GET_ATTRIBUTE_OF_ALL_PAYMENT_URL = "https://sukkarhala1.000webhostapp.com/GetAttributePayment.php?";
    private string GET_ATTRIBUTE_OF_ALL_MENU_URL = "https://sukkarhala1.000webhostapp.com/GetAttributeMenu.php?";

    #region GetAll
    public string GetAllTables()
    {
        WWW post = new WWW(SHOW_ALL_TABLE_URL);


        while (!post.isDone)
        {

        }

        if (post.error != null)
        {
            Debug.Log("There was an error getting all tables: " + post.error);
        }



        return post.text;
    }
    public string GetAllPayment()
    {
        WWW post = new WWW(SHOW_ALL_PAYMENT_URL);


        while (!post.isDone)
        {

        }

        if (post.error != null)
        {
            Debug.Log("There was an error getting all payment: " + post.error);
        }



        return post.text;
    }
    public string GetAllMenu()
    {
        WWW post = new WWW(GET_ATTRIBUTE_OF_ALL_MENU_URL);


        while (!post.isDone)
        {

        }

        if (post.error != null)
        {
            Debug.Log("There was an error getting all menu: " + post.error);
        }



        return post.text;
    }
    #endregion
    #region add
    public void AddTable(string TableNumber, string Booked)
    {
        //Get an array of all tabe nummbers in the database
        string[] _TableNumber = GetAttributeOfAllTables("TableNumber").Split('\t');
        Debug.Log(_TableNumber);

        //create url to use AddUser.php on the webpage
        string post_url = ADD_TABLE_URL + "TableNumber=" + WWW.EscapeURL(TableNumber) + "&Booked=" + Booked;
        Debug.Log(post_url);
        WWW post = new WWW(post_url);

        //wait for process of adding a user to be done
        while (!post.isDone)
        {

        }

        //if there is an error with adding a user return a wrong value(-1)
        if (post.error != null)
        {
            Debug.Log("There was an error posting the user data: " + post.error);
          
        }


    }
    public void AddPayment(string PaymentMethode, string Date, string Total)
    {
        //Get an array of all tabe nummbers in the database
        string[] _PaymentMethode = GetAttributeOfAllPayment("PaymentMethode").Split('\t');
        Debug.Log(_PaymentMethode);

        //create url to use AddUser.php on the webpage
        string post_url = ADD_PAYMENT_URL + "PaymentMethode=" + WWW.EscapeURL(PaymentMethode) + "&Date=" + Date + "&Total=" + Total;
        Debug.Log(post_url);
        WWW post = new WWW(post_url);

        //wait for process of adding a user to be done
        while (!post.isDone)
        {

        }

        //if there is an error with adding a user return a wrong value(-1)
        if (post.error != null)
        {
            Debug.Log("There was an error posting the user data: " + post.error);
            
        }


    }
    public void AddMenu(string Name, string Price, string Amount)
    {
        //Get an array of all tabe nummbers in the database
        string[] _Name = GetAttributeOfAllMenu("Name").Split('\t');
        Debug.Log(_Name);

        //create url to use AddUser.php on the webpage
        string post_url = ADD_MENU_URL + "Name=" + WWW.EscapeURL(Name) + "&Price=" + Price + "&Amount=" + Amount;
        Debug.Log(post_url);
        WWW post = new WWW(post_url);

        //wait for process of adding a user to be done
        while (!post.isDone)
        {

        }

        //if there is an error with adding a user return a wrong value(-1)
        if (post.error != null)
        {
            Debug.Log("There was an error posting the user data: " + post.error);
       
        }


    }
    #endregion
    #region get attribut
    public string GetAttributeOfAllTables(string Attribute)
    {
        string s = GET_ATTRIBUTE_OF_ALL_TABLE_URL + "Attribute= " + Attribute;
        WWW post = new WWW(s);
        Debug.Log(s);
        while (!post.isDone) { };
        if (post.error != null)
        {
            Debug.Log("There was an error getting the attribute of all Tables: " + post.error);
            Debug.Log(post.text);
        }

        return post.text;
    }
    public string GetAttributeOfAllPayment(string Attribute)
    {
        string s = GET_ATTRIBUTE_OF_ALL_PAYMENT_URL + "Attribute= " + Attribute;
        WWW post = new WWW(s);
        Debug.Log(s);
        while (!post.isDone) { };
        if (post.error != null)
        {
            Debug.Log("There was an error getting the attribute of all Payment: " + post.error);
            Debug.Log(post.text);
        }

        return post.text;
    }
    public string GetAttributeOfAllMenu(string Attribute)
    {
        string s = GET_ATTRIBUTE_OF_ALL_MENU_URL + "Attribute= " + Attribute;
        WWW post = new WWW(s);
        Debug.Log(s);
        while (!post.isDone) { };
        if (post.error != null)
        {
            Debug.Log("There was an error getting the attribute of all Menu: " + post.error);
            Debug.Log(post.text);
        }

        return post.text;
    }
    #endregion
    #region Get Data
    public string GetTableData(string ID)
    {
        WWW post = new WWW(GET_TABLE_DATA_URL + "ID=" + ID);
        string s = GET_TABLE_DATA_URL + "ID=" + ID;
        Debug.Log("GetTableData - post: " + s);
        while (!post.isDone) { };
        if (post.error != null)
        {
            Debug.Log("There was an error getting the Table data: " + post.error);
        }

        return post.text;
    }
    public string GetPaymentData(string ID)
    {
        WWW post = new WWW(SHOW_ALL_PAYMENT_URL + "ID=" + ID);
        string s = SHOW_ALL_PAYMENT_URL + "ID=" + ID;
        Debug.Log("GetPaymentData - post: " + s);
        while (!post.isDone) { };
        if (post.error != null)
        {
            Debug.Log("There was an error getting the Payment data: " + post.error);
        }

        return post.text;
    }
    public string GetMenuData(string ID)
    {
        WWW post = new WWW(GET_MENU_DATA_URL + "ID=" + ID);
        string s = GET_MENU_DATA_URL + "ID=" + ID;
        Debug.Log("GetMenuData - post: " + s);
        while (!post.isDone) { };
        if (post.error != null)
        {
            Debug.Log("There was an error getting the Menu data: " + post.error);
        }

        return post.text;
    }
    #endregion


}


