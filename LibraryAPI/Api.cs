using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryAPI
{
    public static class Api
    {
        public static void ConfigureApi(this WebApplication app)
        {
           
            app.MapGet("/Members", GetMembers);
            app.MapGet("/Members/{id}", GetMember);
            app.MapPost("/Members", InsertMember);
            app.MapPut("/Members", UpdateMember);
            app.MapDelete("/Members", DeleteMember);

            
            app.MapGet("/Librarians", GetLibrarians);
            app.MapGet("/Librarians/{id}", GetLibrarian);
            app.MapPost("/Librarians", InsertLibrarian);
            app.MapPut("/Librarians", UpdateLibrarian);
            app.MapDelete("/Librarians", DeleteLibrarian);

            
            app.MapGet("/Books", GetBooks);
            app.MapGet("/Books/{id}", GetBook);
            app.MapPost("/Books", InsertBook);
            app.MapPut("/Books", UpdateBook);
            app.MapDelete("/Books", DeleteBook);

            app.MapGet("/Authors", GetAuthors);
            app.MapGet("/Authors/{id}", GetAuthor);
            app.MapPost("/Authors", InsertAuthor);
            app.MapPut("/Authors", UpdateAuthor);
            app.MapDelete("/Authors", DeleteAuthor);

            app.MapGet("/Publishers", GetPublishers);
            app.MapGet("/Publishers/{id}", GetPublisher);
            app.MapPost("/Publishers", InsertPublisher);
            app.MapPut("/Publishers", UpdatePublisher);
            app.MapDelete("/Publishers", DeletePublisher);
        }

        private static async Task<IResult> GetLibrarians(ILibrarianData data)
        {
            try
            {
                return Results.Ok(await data.GetLibrarians());
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> GetLibrarian(int id, ILibrarianData data)
        {
            try
            {
                var results = await data.GetLibrarian(id);
                if (results == null) return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> InsertLibrarian(LibrarianModel Librarian, ILibrarianData data)
        {
            try
            {
                await data.InsertLibrarian(Librarian);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> UpdateLibrarian(LibrarianModel Librarian, ILibrarianData data)
        {
            try
            {
                await data.UpdateLibrarian(Librarian);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> DeleteLibrarian(int id, ILibrarianData data)
        {
            try
            {
                await data.DeleteLibrarian(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> GetMembers(IMemberData data)
        {
            try
            {
                return Results.Ok(await data.GetMembers());
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> GetMember(int id, IMemberData data)
        {
            try
            {
                var results = await data.GetMember(id);
                if (results == null) return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> InsertMember(MemberModel Member, IMemberData data)
        {
            try
            {
                await data.InsertMember(Member);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> UpdateMember(MemberModel Member, IMemberData data)
        {
            try
            {
                await data.UpdateMember(Member);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> DeleteMember(int id, IMemberData data)
        {
            try
            {
                await data.DeleteMember(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }
    
    

        private static async Task<IResult> GetBooks(IBookData data)
        {
            try
            {
                return Results.Ok(await data.GetBooks());
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> GetBook(int id, IBookData data)
        {
            try
            {
                var result = await data.GetBook(id);
                if (result == null) return Results.NotFound();
                return Results.Ok(result);
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> InsertBook(BookModel book, IBookData data)
        {
            try
            {
                await data.InsertBook(book);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> UpdateBook(BookModel book, IBookData data)
        {
            try
            {
                await data.UpdateBook(book);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> DeleteBook(int id, IBookData data)
        {
            try
            {
                await data.DeleteBook(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> GetAuthors(IAuthorData data)
        {
            try
            {
                return Results.Ok(await data.GetAuthors());
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> GetAuthor(int id, IAuthorData data)
        {
            try
            {
                var result = await data.GetAuthor(id);
                if (result == null) return Results.NotFound();
                return Results.Ok(result);
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> InsertAuthor(AuthorModel Author, IAuthorData data)
        {
            try
            {
                await data.InsertAuthor(Author);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> UpdateAuthor(AuthorModel Author, IAuthorData data)
        {
            try
            {
                await data.UpdateAuthor(Author);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> DeleteAuthor(int id, IAuthorData data)
        {
            try
            {
                await data.DeleteAuthor(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> GetPublishers(IPublisherData data)
        {
            try
            {
                return Results.Ok(await data.GetPublishers());
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> GetPublisher(int id, IPublisherData data)
        {
            try
            {
                var result = await data.GetPublisher(id);
                if (result == null) return Results.NotFound();
                return Results.Ok(result);
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> InsertPublisher(PublisherModel Publisher, IPublisherData data)
        {
            try
            {
                await data.InsertPublisher(Publisher);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> UpdatePublisher(PublisherModel Publisher, IPublisherData data)
        {
            try
            {
                await data.UpdatePublisher(Publisher);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

        private static async Task<IResult> DeletePublisher(int id, IPublisherData data)
        {
            try
            {
                await data.DeletePublisher(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem("Error");
            }
        }

    }
}
