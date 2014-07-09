


    class CSChain
    {
        string _studentType = "";
        string _id = "";
            string _fName = "";
        string _lName = "";

        public Student(string id)
            : this(id, "", ""){

    }

        public Student(string id, string FName)
            :this(id, FName, ""){
        }
    }

public Student(string id, string fName, string lName)
    {
//tests

_studentType = "<student_type>";

_id = id;
_fName = fName;
_lName = lName;
    }

    