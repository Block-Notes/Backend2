CREATE TABLE Notas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Titulo VARCHAR(45),
    Descripcion VARCHAR(1000),
    FechaCreacion DATE,
    HoraModificacion DATETIME,
    Estado VARCHAR(45),
    id_Categoria INT
);

CREATE TABLE Categorias (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(45)
    );

    
CREATE TABLE Archivados (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_Notas INT
);


CREATE TABLE Papeleria (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_Notas INT
);

    
ALTER TABLE Notas ADD FOREIGN KEY (id_Categoria) REFERENCES Categorias(id)