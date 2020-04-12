using ModelDesignFirst_L1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
    public class MyPhotos : IProject
    {
        public Photo CreatePhoto(string fullPath, string photoName, DateTime creationDate, string corelatedEvent, string taggedPersons, string location, int height, int weight)
        {
            return new Photo().CreatePhoto(fullPath, photoName, creationDate, corelatedEvent, taggedPersons, location, height, weight);
        }

        public Movie CreateMovie(string fullPath, string movieName, DateTime creationDate, string corelatedEvent, string taggedPersons, string location, int duration)
        {
            return new Movie().CreateMovie(fullPath, movieName, creationDate, corelatedEvent, taggedPersons, location, duration);
        }

        public User CreateUser(string firstName, string lastName, string email, string password, string phone, string address)
        {
            return new User().CreateUser(firstName, lastName, email, password, phone, address);
        }

        public PropertyCode CreatePropertyCode(string code)
        {
            return new PropertyCode().CreatePropertyCode(code);
        }

        public Property CreateProperty(string desc, int mediaID, int propCodeID)
        {
            return new Property().CreateProperty(desc, mediaID, propCodeID);
        }

        public bool DeletePhoto(int id)
        {
            return new Photo().DeletePhoto(id);
        }

        public bool DeleteUser(int id)
        {
            return new User().DeleteUser(id);
        }

        public bool DeleteMovie(int id)
        {
            return new Movie().DeleteMovie(id);
        }

        public bool DeletePropertyCode(int id)
        {
            return new PropertyCode().DeletePropertyCode(id);
        }

        public List<Photo> GetAllPhotos()
        {
            return new Photo().GetAllPhotos();
        }

        public List<User> GetAllUsers()
        {
            return new User().GetAllUsers();
        }

        public List<Movie> GetAllMovies()
        {
            return new Movie().GetAllMovies();
        }

        public List<PropertyCode> GetPropertyCodes()
        {
            return new PropertyCode().GetPropertyCodes();
        }

        public Photo GetPhotoById(int id)
        {
            return new Photo().GetPhotoById(id);
        }

        public User GetUserById(int id)
        {
            return new User().GetUserById(id);
        }

        public Movie GetMovieById(int id)
        {
            return new Movie().GetMovieById(id);
        }

        public Movie UpdateMovie(int id, string fullPath, string movieName, DateTime creationDate, string corelatedEvent, string taggedPersons, string location, int duration)
        {
            return new Movie().UpdateMovie(id, fullPath, movieName, creationDate, corelatedEvent, taggedPersons, location, duration);
        }

        public Photo UpdatePhoto(int id, string fullPath, string PhotoName, DateTime creationDate, string corelatedEvent, string taggedPersons, string location, int height, int weight)
        {
            return new Photo().UpdatePhoto(id, fullPath, PhotoName, creationDate, corelatedEvent, taggedPersons, location, height, weight);
        }

        public User UpdateUser(int id, string firstName, string lastName, string email, string password, string phone, string address)
        {
            return new User().Update(id, firstName, lastName, email, password, phone, address);
        }

    }
}
