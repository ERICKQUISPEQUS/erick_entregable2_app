using SQLite;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using MiApp.Models;
using Microsoft.Maui.Controls;

public class Database
{
    private SQLiteAsyncConnection _database;

    public Database(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);

        // Crear las tablas para las entidades
        _database.CreateTableAsync<Categoria>().Wait();
        _database.CreateTableAsync<Producto>().Wait();
        _database.CreateTableAsync<Compra_producto>().Wait();
        _database.CreateTableAsync<Bolsa>().Wait();
    }

    // Métodos para Categoria
    public Task<List<Categoria>> GetAllCategoriasAsync()
    {
        return _database.Table<Categoria>().ToListAsync();
    }

    public Task<Categoria> GetCategoriaAsync(int id)
    {
        return _database.Table<Categoria>().FirstOrDefaultAsync(c => c.Id == id);
    }

    public Task<int> SaveCategoriaAsync(Categoria categoria)
    {
        if (categoria.Id != 0)
            return _database.UpdateAsync(categoria);
        else
            return _database.InsertAsync(categoria);
    }

    public Task<int> DeleteCategoriaAsync(int id)
    {
        return _database.DeleteAsync<Categoria>(id);
    }

    // Métodos para Producto
    public Task<List<Producto>> GetAllProductosAsync()
    {
        return _database.Table<Producto>().ToListAsync();
    }

    public Task<Producto> GetProductoAsync(int id)
    {
        return _database.Table<Producto>().FirstOrDefaultAsync(p => p.Id == id);
    }

    public Task<int> SaveProductoAsync(Producto producto)
    {
        if (producto.Id != 0)
            return _database.UpdateAsync(producto);
        else
            return _database.InsertAsync(producto);
    }

    public Task<int> DeleteProductoAsync(int id)
    {
        return _database.DeleteAsync<Producto>(id);
    }

    // Métodos para Compra_producto
    public Task<List<Compra_producto>> GetAllCompra_productosAsync()
    {
        return _database.Table<Compra_producto>().ToListAsync();
    }

    public Task<Compra_producto> GetCompra_productoAsync(int id)
    {
        return _database.Table<Compra_producto>().FirstOrDefaultAsync(p => p.Id == id);
    }

    public Task<int> SaveCompra_productoAsync(Compra_producto compra_producto)
    {
        if (compra_producto.Id != 0)
            return _database.UpdateAsync(compra_producto);
        else
            return _database.InsertAsync(compra_producto);
    }

    public Task<int> DeleteCompra_productoAsync(int id)
    {
        return _database.DeleteAsync<Compra_producto>(id);
    }

    // Métodos para Bolsa
    public Task<List<Bolsa>> GetAllBolsasAsync()
    {
        return _database.Table<Bolsa>().ToListAsync();
    }

    public Task<Bolsa> GetBolsaAsync(int id)
    {
        return _database.Table<Bolsa>().FirstOrDefaultAsync(p => p.Id == id);
    }

    public Task<int> SaveBolsaAsync(Bolsa bolsa)
    {
        if (bolsa.Id != 0)
            return _database.UpdateAsync(bolsa);
        else
            return _database.InsertAsync(bolsa);
    }

    public Task<int> DeleteBolsaAsync(int id)
    {
        return _database.DeleteAsync<Bolsa>(id);
    }
}
