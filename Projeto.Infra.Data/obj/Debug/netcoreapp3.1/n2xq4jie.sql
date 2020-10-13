IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Medico] (
    [IdMedico] int NOT NULL IDENTITY,
    [Nome] nvarchar(100) NOT NULL,
    [Crm] nvarchar(10) NOT NULL,
    [Especializacao] nvarchar(200) NOT NULL,
    CONSTRAINT [PK_Medico] PRIMARY KEY ([IdMedico])
);

GO

CREATE TABLE [Paciente] (
    [IdPaciente] int NOT NULL IDENTITY,
    [Nome] nvarchar(100) NOT NULL,
    [Cpf] nvarchar(15) NOT NULL,
    [DataNascimento] date NOT NULL,
    [Telefone] nvarchar(10) NOT NULL,
    [Email] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_Paciente] PRIMARY KEY ([IdPaciente])
);

GO

CREATE TABLE [Atendimento] (
    [IdAtendimento] int NOT NULL IDENTITY,
    [DataNascimento] date NOT NULL,
    [Local] nvarchar(50) NOT NULL,
    [Observacoes] nvarchar(200) NOT NULL,
    [IdMedico] int NOT NULL,
    [IdPaciente] int NOT NULL,
    CONSTRAINT [PK_Atendimento] PRIMARY KEY ([IdAtendimento]),
    CONSTRAINT [FK_Atendimento_Medico_IdMedico] FOREIGN KEY ([IdMedico]) REFERENCES [Medico] ([IdMedico]) ON DELETE CASCADE,
    CONSTRAINT [FK_Atendimento_Paciente_IdPaciente] FOREIGN KEY ([IdPaciente]) REFERENCES [Paciente] ([IdPaciente]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Atendimento_IdMedico] ON [Atendimento] ([IdMedico]);

GO

CREATE INDEX [IX_Atendimento_IdPaciente] ON [Atendimento] ([IdPaciente]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201013164613_Initial', N'3.1.8');

GO

