using Microsoft.AspNetCore.Mvc;
using web.Data;
using System.Linq;
using web.Migrations;

namespace web.ViewComponents {
    public class RoomViewComponent: ViewComponent{
        private readonly PostContext _context;

        public RoomViewComponent (PostContext context){
            _context = context;
        }
        public IViewComponentResult Invoke(){

        var chats = _context.Chats.ToList();
        return View();
    }

    }

    
} 