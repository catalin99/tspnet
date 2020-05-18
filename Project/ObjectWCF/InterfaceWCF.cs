using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ModelDesignFirst_L1;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceUser
    {
        [OperationContract]
        User CreateUser(string firstName, string lastName, string email, string password, string phone, string address);
        [OperationContract]
        User UpdateUser(int id, string firstName, string lastName, string email, string password, string phone, string address);
        [OperationContract]
        bool DeleteUser(int id);
        [OperationContract]
        User GetUserById(int id);
        [OperationContract]
        List<User> GetAllUsers();
        [OperationContract]
        bool Login(string email, string password);
    }
    [ServiceContract]
    interface InterfacePhoto
    {
        [OperationContract]
        Photo CreatePhoto(string fullPath, string photoName, DateTime creationDate, string corelatedEvent, string taggedPersons, string location, int height, int weight);
        [OperationContract]
        bool DeletePhoto(int id);
        [OperationContract]
        Photo GetPhotoById(int id);
        [OperationContract]
        List<Photo> GetAllPhotos();
        [OperationContract]
        Photo UpdatePhoto(int id, string fullPath, string PhotoName, DateTime creationDate, string corelatedEvent, string taggedPersons, string location, int height, int weight);
    }
    [ServiceContract]
    interface InterfaceMovie
    {
        [OperationContract]
        Movie CreateMovie(string fullPath, string movieName, DateTime creationDate, string corelatedEvent, string taggedPersons, string location, int duration);
        [OperationContract]
        bool DeleteMovie(int id);
        [OperationContract]
        Movie GetMovieById(int id);
        [OperationContract]
        List<Movie> GetAllMovies();
        [OperationContract]
        Movie UpdateMovie(int id, string fullPath, string movieName, DateTime creationDate, string corelatedEvent, string taggedPersons, string location, int duration);
    }

    [ServiceContract]
    interface InterfacePropertyCode
    {
        [OperationContract]
        PropertyCode CreatePropertyCode(string code);
        [OperationContract]
        bool DeletePropertyCode(int id);
        [OperationContract]
        List<PropertyCode> GetPropertyCodes();
    }
    [ServiceContract]
    interface InterfaceProperty
    {
        [OperationContract]
        Property CreateProperty(string desc, int mediaID, int propCodeID);
        [OperationContract]
        List<Property> GetPropertiesByMediaID(int id);
        [OperationContract]
        List<Property> GetPropertiesByCodeID(int id);
    }
    [ServiceContract]
    interface IProject : InterfaceUser, InterfacePhoto, InterfaceMovie, InterfacePropertyCode, InterfaceProperty
    {
    }
}
