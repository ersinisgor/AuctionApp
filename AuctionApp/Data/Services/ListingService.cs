using AuctionApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AuctionApp.Data.Services
{
	public class ListingService : IListingService
	{
		private readonly ApplicationDbContext _context;

		public ListingService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task Add(Listing listing)
		{
			_context.Listings.Add(listing);
			await _context.SaveChangesAsync();
		}

		public IQueryable<Listing> GetAll()
		{
			var applicationDbContext = _context.Listings.Include(l => l.User);
			return applicationDbContext;
		}
	}
}
