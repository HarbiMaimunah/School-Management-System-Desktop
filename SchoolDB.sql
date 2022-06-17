use school;

create table teachers (teacher_id int identity(1,1) not null, 
teacher_firstName varchar(255) not null, 
teacher_lastName varchar(255) not null, 
teacher_birthDate date not null,
teacher_gender varchar(5) check (teacher_gender in ('Fmale','Male')) not null,
teacher_department varchar(255) check (teacher_department in ('Artificial Intelligence', 'Computer Science', 'Software Engineering')) not null,
teacher_salary int check (teacher_salary<=15000) not null,
primary key(teacher_id));

create table students (student_id int identity(1,1) not null, 
student_firstName varchar(255) not null, 
student_lastName varchar(255) not null, 
student_birthDate date not null, 
student_gender varchar(5) check (student_gender in ('Fmale','Male')) not null,
student_enrollment_date date not null,
student_major varchar(255) check (student_major in ('Artificial Intelligence', 'Computer Science', 'Software Engineering')) not null,
student_status varchar(255) check (student_status in ('Active', 'Inactive')) not null,
student_gpa decimal(5,4) check (student_gpa<=5) not null,
primary key(student_id));

create table courses (course_id int identity(1,1) not null,
course_name varchar(255) not null,
primary key(course_id));

create table teachers_courses (teacher_id int not null,
course_id int not null,
foreign key (teacher_id) references teachers(teacher_id),
foreign key (course_id) references courses(course_id));

create table students_courses (student_id int not null,
course_id int not null,
foreign key (student_id) references students(student_id),
foreign key (course_id) references courses(course_id));

go 

create procedure add_course
(
	@course_name varchar(255)
)
as
insert into courses(course_name)
values (@course_name)

go

create procedure edit_course
(
	@course_id int,
	@course_name varchar(255)
)
as
update courses 
set course_name=@course_name
where course_id=@course_id

go

create procedure remove_course
(
	@course_id int
)
as
begin
delete from teachers_courses where course_id = @course_id
delete from students_courses where course_id = @course_id
delete from courses where course_id = @course_id
end
go

create procedure connect_student_course
(
	@student_id int,
	@course_id int
)
as
insert into students_courses(student_id, course_id)
values (@student_id, @course_id)

go

create procedure connect_teacher_course
(
	@teacher_id int,
	@course_id int
)
as
insert into teachers_courses(teacher_id, course_id)
values (@teacher_id, @course_id)

go 

create procedure add_teacher
(
	@teacher_firstName varchar(255), 
	@teacher_lastName varchar(255), 
	@teacher_birthDate date, 
	@teacher_gender varchar(5), 
	@teacher_department varchar(255), 
	@teacher_salary int
)
as
insert into teachers(teacher_firstName, teacher_lastName, teacher_birthDate, teacher_gender, teacher_department, teacher_salary)
values (@teacher_firstName, @teacher_lastName, @teacher_birthDate, @teacher_gender, @teacher_department, @teacher_salary)

go

create procedure edit_teacher
(
	@teacher_id int,
	@teacher_firstName varchar(255), 
	@teacher_lastName varchar(255), 
	@teacher_birthDate date, 
	@teacher_gender varchar(5), 
	@teacher_department varchar(255), 
	@teacher_salary int
)
as
update teachers
set teacher_firstName=@teacher_firstName,
teacher_lastName=@teacher_lastName,
teacher_birthDate=@teacher_birthDate,
teacher_gender=@teacher_gender,
teacher_department=@teacher_department,
teacher_salary=@teacher_salary
where teacher_id=@teacher_id

go

create procedure remove_teacher
(
	@teacher_id int
)
as
begin
delete from teachers_courses where teacher_id = @teacher_id
delete from teachers where teacher_id = @teacher_id
end

go

create procedure add_student
(
	@student_firstName varchar(255), 
	@student_lastName varchar(255), 
	@student_birthDate date, 
	@student_gender varchar(5), 
	@student_enrollment_date date, 
	@student_major varchar(255), 
	@student_status varchar(255), 
	@student_gpa decimal(5,4)
)
as
insert into students(student_firstName, student_lastName, student_birthDate, student_gender, student_enrollment_date, student_major, student_status, student_gpa)
values (@student_firstName, @student_lastName, @student_birthDate, @student_gender, @student_enrollment_date, @student_major, @student_status, @student_gpa)

go

create procedure edit_student
(
	@student_id int,
	@student_firstName varchar(255), 
	@student_lastName varchar(255), 
	@student_birthDate date, 
	@student_gender varchar(5), 
	@student_enrollment_date date, 
	@student_major varchar(255), 
	@student_status varchar(255), 
	@student_gpa decimal(5,4)
)
as 
update students
set student_firstName=@student_firstName,
student_lastName=@student_lastName,
student_birthDate=@student_birthDate,
student_gender=@student_gender,
student_enrollment_date=@student_enrollment_date,
student_major=@student_major,
student_status=@student_status,
student_gpa=@student_gpa
where student_id=@student_id

go

create procedure remove_student
(
	@student_id int
)
as
begin
delete from students_courses where student_id=@student_id
delete from students where student_id=@student_id
end