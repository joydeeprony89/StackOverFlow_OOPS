using System;
using System.Collections.Generic;

namespace StackOverFlow_OOPS
{
    class StackOverFlow
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public enum QuestionStatus
        {
            Open,
            Closed,
            OnHold,
            Deleted
        }

        public enum QuestionClosingStatus
        {
            Duplicate,
            Inappropriate,
            NotConstructive,
            TooBroad
        }

        public enum AccountStatus
        {
            Open,
            Blocked,
            Unblocked,
            BlackListed
        }

        public class Account
        {
            string name;
            string email;
            DateTime crationdate;
            AccountStatus status;
            Image image;
            int reputation;

            bool resetPassword();
        }

        public abstract class Member
        {
            Account account;
            List<Question> questions;
            List<Answer> answers;
            List<Badge> badges;

            int getReputation();
            string getEmail();
            bool createQuestion(Question question);
            bool createTag(Tag tag);
        }

        public class Admin : Member
        {
            bool block(Account account);
            bool unblock(Account account);
        }

        public class Moderator : Member
        {
            bool undeletequestion(Question question);
            bool closeQuestion(Question question);
            bool updatequestion(Question question);
        }

        public class Badge
        {
            string name;
            string description;
        }

        public class Tag
        {
            string name;
            string description;
            int weeklyView;
        }


        public class Image
        {
            int imageid;
            string path;
            DateTime crationdate;
            Member cratedby;

            bool Delete(Image image);
        }

        public class Question : Search
        {
            string title;
            string description;
            Member createdby;
            QuestionStatus status;

            List<Comment> comments;
            List<Answer> asnwers;
            int noofvote;

            public List<Question> SearchQuestion(string name)
            {
                throw new NotImplementedException();
            }

            bool Delete(Question question);
        }

        public class Comment
        {
            string content;
            int votes;
            int flags;
            DateTime creationdate;
            Member commentMaker;

        }

        public class Answer
        {
            string content;
            int vote;
            Image image;
            List<Comment> comments;
            Member answeredBy;
        }

        public interface Search
        {
            List<Question> SearchQuestion(string name);
        }
    }
}
