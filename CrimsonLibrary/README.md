Web Api to keep track of things i do 

finance [O]
  |- monthly stuff 
    |- depends on weekly
    |- monthly subs
  |- weekly 
    |- depends on daily
  |- daily
    |- money spent daily (null is ok)

workouts [O]
  |- cycle (month and two weeks)
  |- daily logging 
    |- each workout is a class

games [O]
  |- games played
  |- wanting to play
  |- games done
  |- fave games 
reading [O]
  |- books read
  |- books important to read 
  |- books reading
  |- done reading
  |- favourite books
music
  |- albums
  |- fav tracks
  |- bands
anime [O]
  |- watched
    |- rating
  |- watching
  |- wanting to watch
manga [O]
  |- reading
  |- read
  |- done
movies
  |- watched
  |- will watch
  |- done
shows
  |- watched 
  |- will watch
  |- done
decks 
 |- fave cards 
 |- most fave card
 |- 




 queries :

 bought item -> 
    |- get() returns new class containing [bought items]
    |- create() 
    |- update()
    |- delete()


create anime example:
{
    name:"Gatcha-man crowds insight",
    description: "",
    coverImage: "",
    Genre: "",
    SubGenres: "action, comedy, sci-fi",
    tags : "tag1, tag2, tag3",
    faveCharacter: "hajime",
    isWatched : true,
    onGoing: false
}
create game example:
{
    name:"Elden Ring",
    description: "",
    coverImage: "",
    Genre: "",
    SubGenres: "action, comedy, sci-fi",
    tags : "tag1, tag2, tag3",
    FaveCharacter: "patches",
    isPlaying: true,
    DonePlaying: ! isPlaying,
    favorite : true
}

create manga example:
{
    name:"Bastard!!",
    description: "",
    coverImage: "",
    Genre: "",
    SubGenres: "action, comedy, sci-fi",
    tags : "tag1, tag2, tag3",
    faveCharacter : "Darch",
    artists: "",
    authors : "",
    series: "",
    chapters : 200,
    Completed : false,
    ReadToFinish : true 
}

create book example:
{
    name:"Fulgrim",
    description: "",
    coverImage: "",
    Genre: "",
    SubGenres: "action, comedy, sci-fi",
    tags : "tag1, tag2, tag3",
    series : "",
    pages : 600,
    Favorite : true,

}

create workout example:
{
    too long ;=;
}


