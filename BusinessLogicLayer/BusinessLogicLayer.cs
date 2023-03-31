using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;




public class BusinessLogicLayer
{

    InventoryManagerContext? inventoryManagerContext;

    #region Login Method


    public bool Login(string username, string password, string userType)
    {
        bool isLoggedIn = false;
        inventoryManagerContext = new InventoryManagerContext();

        try
        {
            if (inventoryManagerContext.TblUsers.Where(u => u.Username == username && u.Password == password && u.UserType == userType).Count() > 0)
            {
                isLoggedIn = true;

            }
            else
            {
                isLoggedIn = false;

            }

        }
        catch (Exception ex)
        {
            throw new ApplicationException(ex.Message);
        }
        return isLoggedIn;
    }
    #endregion

    #region Generic Select Method
    
    public object Select<T>(DbSet<T> table) where T : class
    {
        inventoryManagerContext = new InventoryManagerContext();
        var listValues = inventoryManagerContext.Set<T>().ToList();
        return listValues;
    }
    #endregion

    #region Generic Insert Method
    public bool Insert<T>(T c) where T: class
    {
        bool isOkay = false;
        try
        {

            inventoryManagerContext = new InventoryManagerContext();
            inventoryManagerContext.Set<T>().Add(c);
           
            inventoryManagerContext.SaveChanges();
            isOkay = true;
        }
        catch(Exception ex)

        {
            isOkay = false;
           
            throw new ApplicationException("This is the Error " + ex.Message);
        }
        return isOkay;
    }
    #endregion

    #region Get The User ID based on the Username
    public int GetUserID(string username)
    {
        inventoryManagerContext = new InventoryManagerContext();

        var query = inventoryManagerContext.TblUsers.FirstOrDefault(u => u.Username == username);
        int userID = int.Parse(query!.Id.ToString());

        return userID;
    }

    #endregion

    #region Generic Update Method
    public bool Update<T>(T c )where T : class
    {
        bool isOkay = false;

        try
        {
            inventoryManagerContext = new InventoryManagerContext();
            inventoryManagerContext.Set<T>().Update(c);
            inventoryManagerContext.SaveChanges();
            isOkay = true;

        }catch(Exception ex)
        {
            throw new ApplicationException(ex.Message);
        }

        return isOkay;

    }

    #endregion

    #region Generic Delete Method
    public bool Delete<T>(T a) where T : class
    {
        {
            bool isOkay = false;
            try
            {
                inventoryManagerContext = new InventoryManagerContext();
               

                inventoryManagerContext.Set<T>().Remove(a);
                inventoryManagerContext.SaveChanges();
                isOkay = true;
                
            }catch(Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

            return isOkay;
        }
    }
    #endregion

    #region Generic Search Method 
    public object Search<T>(DbSet<T> table, Expression<Func<T, bool>> predicate) where T : class
    {

        inventoryManagerContext = new InventoryManagerContext();
        var listValues = inventoryManagerContext.Set<T>().Where(predicate).ToList();

        return listValues;
    }

    #endregion

}

