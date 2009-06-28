SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ez_univ](
	[univ_code] [uniqueidentifier] NOT NULL,
	[univ_name] [varchar](50) NULL,
	[college_code] [uniqueidentifier] NOT NULL,
	[college_name] [varchar](50) NULL,
	[note] [varchar](2000) NULL,
 CONSTRAINT [PK_univ_code] PRIMARY KEY CLUSTERED 
(
	[univ_code] ASC,
	[college_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ez_profiles](
	[profile_code] [uniqueidentifier] NOT NULL,
	[full_name] [varchar](50) NULL,
	[user_name] [varchar](25) NULL,
	[password] [varchar](50) NULL,
	[gender] [char](1) NULL,
	[birth_date] [datetime] NULL,
	[email] [varchar](50) NULL,
	[mobile] [varchar](20) NULL,
	[phone] [varchar](20) NULL,
	[address] [varchar](50) NULL,
	[photo] [varbinary](max) NULL,
	[interests] [varchar](50) NULL,
	[job] [varchar](50) NULL,
	[hidden] [bit] NULL,
 CONSTRAINT [PK_Profile] PRIMARY KEY CLUSTERED 
(
	[profile_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ez_enrollment](
	[student_code] [uniqueidentifier] NOT NULL,
	[subject_code] [uniqueidentifier] NOT NULL,
	[inst_code] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Ez_enrollment] PRIMARY KEY CLUSTERED 
(
	[student_code] ASC,
	[subject_code] ASC,
	[inst_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ez_subjects](
	[subject_code] [uniqueidentifier] NOT NULL,
	[subject_title] [varchar](50) NULL,
	[univ_code] [uniqueidentifier] NULL,
	[college_code] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Ez_subjects] PRIMARY KEY CLUSTERED 
(
	[subject_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ez_instructors](
	[inst_code] [uniqueidentifier] NOT NULL,
	[inst_active_flag] [varchar](1) NULL,
	[univ_code] [uniqueidentifier] NULL,
	[college_code] [uniqueidentifier] NULL,
	[profile_code] [uniqueidentifier] NULL,
 CONSTRAINT [PK_EZ_instructors] PRIMARY KEY CLUSTERED 
(
	[inst_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ez_topics](
	[topic_code] [uniqueidentifier] NOT NULL,
	[topic_title] [varchar](50) NULL,
	[subject_code] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Ez_topics_1] PRIMARY KEY CLUSTERED 
(
	[topic_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ez_topic_lectures](
	[topic_code] [uniqueidentifier] NOT NULL,
	[lec_code] [uniqueidentifier] NOT NULL,
	[lec_title] [varchar](50) NULL,
	[lec_subj1] [varchar](5000) NULL,
	[lec_subj2] [varchar](5000) NULL,
 CONSTRAINT [PK_Ez_topic_lectures] PRIMARY KEY CLUSTERED 
(
	[lec_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ez_lec_slides](
	[lec_code] [uniqueidentifier] NOT NULL,
	[slide_code] [uniqueidentifier] NOT NULL,
	[slide_text1] [varchar](5000) NULL,
	[slide_text2] [varchar](5000) NULL,
	[slide_text3] [varchar](5000) NULL,
	[slide_active_flag] [varchar](1) NULL,
 CONSTRAINT [PK_Ez_lec_slides] PRIMARY KEY CLUSTERED 
(
	[slide_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ez_students](
	[student_code] [uniqueidentifier] NOT NULL,
	[stu_active_flag] [varchar](1) NULL,
	[profile_code] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Ez_students] PRIMARY KEY CLUSTERED 
(
	[student_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [Ez_enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Ez_enrollment_EZ_instructors] FOREIGN KEY([inst_code])
REFERENCES [Ez_instructors] ([inst_code])
GO
ALTER TABLE [Ez_enrollment] CHECK CONSTRAINT [FK_Ez_enrollment_EZ_instructors]
GO
ALTER TABLE [Ez_enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Ez_enrollment_Ez_students] FOREIGN KEY([student_code])
REFERENCES [Ez_students] ([student_code])
GO
ALTER TABLE [Ez_enrollment] CHECK CONSTRAINT [FK_Ez_enrollment_Ez_students]
GO
ALTER TABLE [Ez_enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Ez_enrollment_Ez_subjects] FOREIGN KEY([subject_code])
REFERENCES [Ez_subjects] ([subject_code])
GO
ALTER TABLE [Ez_enrollment] CHECK CONSTRAINT [FK_Ez_enrollment_Ez_subjects]
GO
ALTER TABLE [Ez_instructors]  WITH CHECK ADD  CONSTRAINT [FK_ez_inst] FOREIGN KEY([univ_code], [college_code])
REFERENCES [Ez_univ] ([univ_code], [college_code])
GO
ALTER TABLE [Ez_instructors] CHECK CONSTRAINT [FK_ez_inst]
GO
ALTER TABLE [Ez_instructors]  WITH CHECK ADD  CONSTRAINT [FK_EZ_instructors_Profile] FOREIGN KEY([profile_code])
REFERENCES [Ez_profiles] ([profile_code])
GO
ALTER TABLE [Ez_instructors] CHECK CONSTRAINT [FK_EZ_instructors_Profile]
GO
ALTER TABLE [Ez_lec_slides]  WITH CHECK ADD  CONSTRAINT [FK_Ez_lec_slides_Ez_topic_lectures] FOREIGN KEY([lec_code])
REFERENCES [Ez_topic_lectures] ([lec_code])
GO
ALTER TABLE [Ez_lec_slides] CHECK CONSTRAINT [FK_Ez_lec_slides_Ez_topic_lectures]
GO
ALTER TABLE [Ez_students]  WITH CHECK ADD  CONSTRAINT [FK_Ez_students_Profile] FOREIGN KEY([profile_code])
REFERENCES [Ez_profiles] ([profile_code])
GO
ALTER TABLE [Ez_students] CHECK CONSTRAINT [FK_Ez_students_Profile]
GO
ALTER TABLE [Ez_subjects]  WITH CHECK ADD  CONSTRAINT [FK_ez_sub] FOREIGN KEY([univ_code], [college_code])
REFERENCES [Ez_univ] ([univ_code], [college_code])
GO
ALTER TABLE [Ez_subjects] CHECK CONSTRAINT [FK_ez_sub]
GO
ALTER TABLE [Ez_topic_lectures]  WITH CHECK ADD  CONSTRAINT [FK_Ez_topic_lectures_Ez_topics] FOREIGN KEY([topic_code])
REFERENCES [Ez_topics] ([topic_code])
GO
ALTER TABLE [Ez_topic_lectures] CHECK CONSTRAINT [FK_Ez_topic_lectures_Ez_topics]
GO
ALTER TABLE [Ez_topics]  WITH CHECK ADD  CONSTRAINT [FK_Ez_topics_Ez_subjects] FOREIGN KEY([subject_code])
REFERENCES [Ez_subjects] ([subject_code])
GO
ALTER TABLE [Ez_topics] CHECK CONSTRAINT [FK_Ez_topics_Ez_subjects]
GO
