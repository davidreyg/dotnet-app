namespace DE.Application.Common
{
    public static class MessageConstant
    {
        //ingles

        //español
        public const string MESSAGE_SUCCESS = "Operación exitosa.";
        public const string MESSAGE_FAILED = "Operación fallida.";
        public const string MESSAGE_ERROR = "Ocurrió un error, intente más tarde.";
        public const string MESSAGE_VALIDATION_ERROR = "Algunos campos contienen errores.";
        public const string MESSAGE_REQUIRE_VALIDATION = "Error de validación.";
        public const string MESSAGE_QUERY_SUCCESS = "Consulta exitosa.";
        public const string MESSAGE_SAVE_SUCCESS = "Se registró correctamente.";
        public const string MESSAGE_SAVE_ERROR = "No se pudo registrar.";
        public const string MESSAGE_UPDATE_SUCCESS = "Se actualizó correctamente.";
        public const string MESSAGE_RESET_PASSWORD = "Contraseña restablecido correctamente.";
        public const string MESSAGE_DELETE_SUCCESS = "Se eliminó correctamente.";
        public const string MESSAGE_QUERY_EMPTY = "No se encontraron registros.";
        public const string MESSAGE_EXISTS = "El registro ya existe";
        public const string MESSAGE_NOT_FOUND = "El registro no existe";
        public const string MESSAGE_USER_EXISTS = "El usuario ya existe";
        public const string MESSAGE_CREDENTIAL_FAILED = "Credenciales incorrectos";
        public const string MESSAGE_REFRESH_TOKEN_ERROR = "Refresh Token inválido o expirado.";

        // Errores de base de datos
        public const string MESSAGE_FOREIGN_KEY_DELETE_CONFLICT =
            "No se puede eliminar el registro porque está relacionado con otros datos.";
        public const string MESSAGE_FOREIGN_KEY_UPDATE_CONFLICT =
            "No se puede guardar el registro porque una relación no es válida.";
        public const string MESSAGE_UNIQUE_CONFLICT =
            "Ya existe un registro con valores únicos duplicados.";
        public const string MESSAGE_DATABASE_ERROR = "Error de base de datos inesperado.";
        public const string MESSAGE_RECORD_NOT_FOUND = "El registro no existe.";

        public const string MESSAGE_PERSON_NOT_FOUND =
            "No se encontró ninguna persona con los datos proporcionados.";

        // Mensajes sobre stock
        public const string MESSAGE_OUT_OF_STOCK = "El producto no tiene stock disponible.";
        public const string MESSAGE_INSUFFICIENT_STOCK =
            "Stock insuficiente para la cantidad solicitada.";
        public const string MESSAGE_STOCK_UPDATED = "Stock actualizado correctamente.";
        public const string MESSAGE_STOCK_NOT_AVAILABLE =
            "Stock no disponible en el almacén seleccionado.";
        public const string MESSAGE_PRODUCT_ALREADY_IN_ORDER =
            "El producto ya fue agregado al pedido.";
        public const string MESSAGE_STOCK_EXCEEDS_LIMIT =
            "La cantidad ingresada excede el stock disponible.";
        public const string MESSAGE_STOCK_ADJUSTMENT_SUCCESS =
            "Ajuste de stock realizado correctamente.";
        public const string MESSAGE_INVALID_STOCK_VALUE =
            "El valor ingresado para el stock no es válido.";
        public const string MESSAGE_CANNOT_REMOVE_STOCK =
            "No se puede retirar más stock del disponible.";
        public const string MESSAGE_NO_PRODUCTS_WITH_STOCK =
            "No hay productos con stock disponible.";
    }
}
