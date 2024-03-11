using AuctionApp.Models;

namespace AuctionApp.Data.Services
{
	public interface IListingService
	{
		IQueryable<Listing> GetAll();
	}
}
