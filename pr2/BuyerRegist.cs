using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class BuyerRegist
    {
        public enum Statuses
        {
            Возвращено,
            Невозвращено
        }

        private Buyer buyer;
        private Film film;
        private DateTime issueDate;
        private DateTime returnDate;
        private Statuses status;
        public string BuyerName
        {
            get
            {
                return buyer != null ? $"{buyer.Name}" : "";
            }
        }
        public string FilmTitle
        {
            get
            {
                return film != null ? film.Title : "";
            }
        }
        private Buyer Reader { get => buyer; }
        private Film Book { get => film; }
        public DateTime IssueDate { get => issueDate; }
        public DateTime ReturnDate { get => returnDate; }
        public Statuses Status { get => status; }
        public BuyerRegist(Buyer buyer, Film film, DateTime issueDate, DateTime returnDate, Statuses status)
        {
            this.buyer = buyer;
            this.film = film;
            this.issueDate = issueDate;
            this.returnDate = returnDate;
            this.status = status;
        }
    }
}
