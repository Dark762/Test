using System;
using System.Collections.Generic;
using System.Linq;
using TestDDD.Domain.Entities;
using TestDDD.Domain.Interfaces.Repositories;

namespace TestDDD.Infraestructure.Data.Repositories
{
    /**
      * <summary>Clase genérica que puede ser utilizado por cualquier entidad, se encarga de realizar las consultas a Entity Framework.</summary>
      */
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        public StatusResponse add(TEntity entity)
        {
            try
            {
                using (var context = new ContextData())
                {

                    context.Add(entity);
                    var result = context.SaveChanges();

                    return new StatusResponse()
                    {
                        Success = true,
                        Value = true
                    };

                }
            }//Fin del try
            catch (Exception ex)
            {
                return new StatusResponse() { 
                    Success = false,
                    Value = false
                };

            }
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> getAll()
        {
            try
            {
                using (var context = new ContextData())
                {
                    //context.Set<TEntity>().Add(entity);


                    var Lista = context.Cliente.ToList();
                                


                    return (IEnumerable<TEntity>)Lista;
                }
            }//Fin del try
            catch (Exception ex)
            {
                throw new Exception("No se puede guardar el registro", ex);
            }
        }

        public TEntity getById(int id)
        {
            throw new NotImplementedException();
        }

 

        public void modify(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }//Fin de la clase BaseRepository
}
