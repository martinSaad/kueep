﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parse;

namespace final.Models
{
    interface ParseInterface
    {
        //business
        Task<ParseObject> retrieveMyBusiness();
        Task<ParseObject> retrieveBusiness(string businessId);


        //product
        Task<IEnumerable<ParseObject>> businessesWhoHaveThisProduct(ParseObject product);
        Task<IEnumerable<ParseObject>> retrieveAllProducts();
        Task<ParseObject> retrieveProduct(string productID);
        Task<IEnumerable<ParseObject>> retrieveAllMyPoducts(string businessId);


        //group
        Task<IEnumerable<ParseObject>> retrieveAllActiveGroups();
        Task<IEnumerable<ParseObject>> retrieveUsersOfGroup(ParseObject group);
        Task<ParseObject> retrieveProductOfGroup(ParseObject group);
        Task<ParseObject> retrieveGroup(string groupId);
        Task<bool> createGroup(ParseObject product);

        //winning bid
        Task<IEnumerable<ParseObject>> retrieveWinningBids();
        Task<ParseObject> retrieveBidOfWinningBid(ParseObject winningBid);

        //bid
        Task<ParseObject> retrieveGroupOfBid(ParseObject bid);
        Task<bool> createBid(ParseObject business, string groupId, double maxUnits, double originalPrice, double priceStep1, double priceStep2, double priceStep3, double priceStep4, double priceStep5, string comments, double guarantee, bool shipping);

        //category
        Task<IEnumerable<ParseObject>> retrieveCategories();

        //subcategory
        Task<IEnumerable<ParseObject>> retrieveSubCategories();

    }

}
