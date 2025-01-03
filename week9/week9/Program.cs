using week9;

MediaFile soundFile = new MP3File("song.mp3");
MediaFile movieFile = new MP4File("movie.mp4");

MP3Player mP3Player = new MP3Player();
MP4Player mP4Player = new MP4Player();

MediaPlayer mp3Adapter = new MP3PlayerAdapter(mP3Player);
MediaPlayer mp4Adapter = new MP4PlayerAdapter(mP4Player);

MediaPlayer mp;
mp = mp3Adapter;
mp.play(soundFile);

mp = mp4Adapter;
mp.play(movieFile);

