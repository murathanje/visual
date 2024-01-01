CREATE TABLE users (
  id INT PRIMARY KEY,
  first_name VARCHAR(255),
  last_name VARCHAR(255),
  email VARCHAR(255),
  age INT,
  height INT,
  weight INT,
  phone VARCHAR(255),
  started_at TIMESTAMP NULL DEFAULT NULL,
  ended_at TIMESTAMP NULL DEFAULT NULL,
  created_at TIMESTAMP NULL DEFAULT NULL
);

CREATE TABLE logs (
  id INT PRIMARY KEY,
  entered_at TIMESTAMP NULL DEFAULT NULL,
  exited_at TIMESTAMP NULL DEFAULT NULL,
  user_id INT,
  created_at TIMESTAMP NULL DEFAULT NULL,
  FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE TABLE Exercises (
  id INT PRIMARY KEY,
  title VARCHAR(255),
  set_times INT,
  rep_times INT,
  day VARCHAR(255),
  work_desc VARCHAR(255),
  workout_place VARCHAR(255),
  user_id INT,
  FOREIGN KEY (user_id) REFERENCES users(id)
);
