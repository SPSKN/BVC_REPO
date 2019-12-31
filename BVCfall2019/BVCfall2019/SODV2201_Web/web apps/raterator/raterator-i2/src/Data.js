const Data = JSON.stringify({
  RateratorSchemaVersion: 1,

  Schools: [
    { Name: "Calgary College Of The Arts", SchoolSid: "CCARTS" },
    { Name: "Bow Ridge College", SchoolSid: "BOWRID" },
    { Name: "Calgary Coding Bootcamp", SchoolSid: "CCBOOT" },
    { Name: "Alberta Machine Learning Institute", SchoolSid: "AMLINS" },
    { Name: "JavaScript Judo Academy", SchoolSid: "JJACAD" }
  ],

  Instructors: [
    { Instructor: "Sidney Thompson", InstructorSid: "SIDTHO" },
    { Instructor: "Stephanie Chan", InstructorSid: "STECHA" },
    { Instructor: "Emma Jones", InstructorSid: "EMMJON" },
    { Instructor: "Peter Van Gogh", InstructorSid: "PETVAN" },
    { Instructor: "T.G. Best", InstructorSid: "TGBEST" },
    { Instructor: "Sean Harrison", InstructorSid: "SEAHAR" },
    { Instructor: "Riley Robertson", InstructorSid: "RILROB" }
  ],

  Likes: [
    { InstructorSid: "SIDTHO", Likes: 45 },
    { InstructorSid: "STECHA", Likes: 90 },
    { InstructorSid: "EMMJON", Likes: 102 },
    { InstructorSid: "PETVAN", Likes: 85 },
    { InstructorSid: "TGBEST", Likes: 385 },
    { InstructorSid: "SEAHAR", Likes: 35 },
    { InstructorSid: "RILROB", Likes: 225 }
  ],

  Ratings: [
    {
      InstructorSid: "SIDTHO",
      SchoolSid: "CCARTS",
      Rating: 3.5,
      Username: "codeninja ",
      SubmittedOnUtc: "2016-03- 01T07:00:00.000Z"
    },
    {
      InstructorSid: "SIDTHO",
      SchoolSid: "CCARTS",
      Rating: 2.5,
      Username: "aiaiai",
      SubmittedOnUtc: "2018-02- 14T07:00:00.000Z"
    },
    {
      InstructorSid: "EMMJON",
      SchoolSid: "BOWRID",
      Rating: 3.95,
      Username: "igetw hatclosuresare",
      SubmittedOnUtc: "2018-06- 12T06:00:00.000Z"
    },
    {
      InstructorSid: "SIDTHO",
      SchoolSid: "CCARTS",
      Rating: 2.1,
      Username: "superde v",
      SubmittedOnUtc: "2018-05- 16T06:00:00.000Z"
    },
    {
      InstructorSid: "EMMJON",
      SchoolSid: "BOWRID",
      Rating: 4.25,
      Username: "super dev",
      SubmittedOnUtc: "2018-07- 15T06:00:00.000Z"
    },
    {
      InstructorSid: "PETVAN",
      SchoolSid: "CCARTS",
      Rating: 3.1,
      Username: "iotrocke r",
      SubmittedOnUtc: "2018-05- 02T06:00:00.000Z"
    },
    {
      InstructorSid: "RILROB",
      SchoolSid: "BOWRID",
      Rating: 5,
      Username: "sharpc",
      " SubmittedOnUtc": "2018-12- 02T07:00:00.000Z"
    },
    {
      InstructorSid: "PETVAN",
      SchoolSid: "CCARTS",
      Rating: 3.8,
      Username: "dbjedi",
      SubmittedOnUtc: "2018-11- 12T07:00:00.000Z"
    },
    {
      InstructorSid: "RILROB",
      SchoolSid: "BOWRID",
      Rating: 5,
      Username: "dreamsin code",
      SubmittedOnUtc: "2017-09-24T06:00:00.000Z"
    }
  ]
});

export { Data };
