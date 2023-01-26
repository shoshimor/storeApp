﻿namespace Dal;
using DalApi;
using DO;
using System;
using System.Xml.Serialization;
/// <summary>
/// CRUD operations department:
/// for adding a new product,
/// reading the existing product,
/// updating product and deletions.
/// </summary>
internal class Product : IProduct
{
    /// <summary>
    /// creates new product.
    /// </summary>
    /// <param name="product"></param>
    /// <returns></returns>
    public int Create(DO.Product product)
    {
        List<DO.Product> productList = ReadAll().ToList();
        bool idExists;
        int barcode;
        Random rand = new Random();
       
        do
        {
            idExists = true;
            barcode = (int)rand.NextInt64(100000, 1000000);
           foreach(var p in productList)
                if (p.ID == barcode)
                    idExists = false;
        } while (!idExists);
        product.ID = barcode;
        
        productList.Add(product);
        XmlSerializer ser = new XmlSerializer(typeof(List<Product>));
        StreamWriter w = new StreamWriter(@"..\xml\product.xml");
        ser.Serialize(w, productList);
        w.Close();
        return product.ID;
       

    }

    /// <summary>
    /// deletes product according to it's ID.
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="NotExistException"></exception>
    public void Delete(int id)
    {
        List<DO.Product> productList = ReadAll().ToList();
        bool deleted = productList.Remove(productList.Find(p => p.ID == id));
        if (!deleted)
            throw new NotExistException();
        XmlSerializer ser = new XmlSerializer(typeof(List<Product>));
        StreamWriter write = new StreamWriter("../../xml/product.xml");
        ser.Serialize(write, productList);
        write.Close();
        
    }

  
    /// <summary>
    /// read all products by default or according to certain condition.
    /// </summary>
    /// <param name="condition"></param>
    /// <returns></returns>
    /// <exception cref="NotExistException"></exception>
    public IEnumerable<DO.Product> ReadAll(Func<DO.Product, bool>? condition = null)
    {
        List<DO.Product> ? productList = new List<DO.Product>();
        StreamReader r = new(@"..\xml\Product.xml");
        XmlSerializer ser = new(typeof(List<DO.Product>));
        productList = (List<DO.Product>)ser?.Deserialize(r);
        r.Close();
        return condition == null ? productList : (productList.Where(condition).ToList() ?? throw new NotExistException());

    
}

    /// <summary>
    /// read specific product that implement certain condition.
    /// </summary>
    /// <param name="condition"></param>
    /// <returns></returns>
    public DO.Product Read(Func<DO.Product, bool> condition)
    {
        return ReadAll(condition).First();
    }

    /// <summary>
    /// updates product property
    /// </summary>
    /// <param name="product"></param>
    /// <exception cref="NotExistException"></exception>
    public void UpDate(DO.Product product)
    {
        List<DO.Product> productList = ReadAll().ToList();
        productList[productList.FindIndex(p => p.ID == product.ID)] = product;
        int idx = productList.FindIndex(p => p.ID == product.ID);
        if (idx <0)
            throw new NotExistException();
        product.Name = product.Name == null ? productList[idx].Name : product.Name;
        product.InStock = product.InStock == null ? productList[idx].InStock : product.InStock;
        product.Price = product.Price == null ? productList[idx].Price : product.Price;
        product.Category = product.Category == null ? productList[idx].Category : product.Category;
        productList[idx] = product;
        XmlSerializer ser = new XmlSerializer(typeof(List<Product>));
        StreamWriter w = new StreamWriter("../../xml/Product.xml");
        ser.Serialize(w, productList);
        w.Close();
       
    }
}
