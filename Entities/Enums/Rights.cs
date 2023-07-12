namespace Entities.Enums
{
    /// <summary>
    /// Les droits utilisateurs sur un calendrier ou un donneur d'ordre.
    /// </summary>
    public enum Rights
    {
        /// <summary>
        /// A tous les droits
        /// </summary>
        ADMIN,

        /// <summary>
        /// Droit en lecture sur la principale fonctionnalité de l'application
        /// </summary>
        READ,

        /// <summary>
        /// Droit en écriture sur la principale fonctionnalité de l'application
        /// </summary>
        WRITE,

        /// <summary>
        /// Peut créer un agenda
        /// </summary>
        CREATE_CALENDAR,

        /// <summary>
        /// Peut consulter les paramètres d’un agenda (propriétés, contraintes, catégories possibles, retours possibles …)
        /// </summary>
        READ_CALENDAR,

        /// <summary>
        /// Peut modifier les paramètres d’un agenda (propriétés, contraintes, catégories possibles, retours possibles …)
        /// </summary>
        WRITE_CALENDAR,

        /// <summary>
        /// Peut supprimer un agenda
        /// </summary>
        DELETE_CALENDAR,

        /// <summary>
        /// Peut créer une entrée de type RDV
        /// </summary>
        CREATE_RDV_ENTRY,

        /// <summary>
        /// Peut lire une entrée de type RDV
        /// </summary>
        READ_RDV_ENTRY,

        /// <summary>
        /// Peut modifier une entrée de type RDV
        /// </summary>
        WRITE_RDV_ENTRY,

        /// <summary>
        /// Peut supprimer une entrée de type RDV
        /// </summary>
        DELETE_RDV_ENTRY,

        /// <summary>
        /// Peut créer une entrée de type autre que RDV
        /// </summary>
        CREATE_OTHER_ENTRY,

        /// <summary>
        /// Peut lire une entrée de type autre que RDV
        /// </summary>
        READ_OTHER_ENTRY,

        /// <summary>
        /// Peut modifier une entrée de type autre que RDV
        /// </summary>
        WRITE_OTHER_ENTRY,

        /// <summary>
        /// Peut supprimer une entrée de type autre que RDV
        /// </summary>
        DELETE_OTHER_ENTRY,

        /// <summary>
        /// Peut créer un retour sur une entrée de type RDV
        /// </summary>
        CREATE_RDV_FEEDBACK,

        /// <summary>
        /// Peut lire un retour sur une entrée de type RDV
        /// </summary>
        READ_RDV_FEEDBACK,

        /// <summary>
        /// Peut modifier un retour sur une entrée de type RDV
        /// </summary>
        WRITE_RDV_FEEDBACK,

        /// <summary>
        /// Peut supprimer un retour sur une entrée de type RDV
        /// </summary>
        DELETE_RDV_FEEDBACK,

        /// <summary>
        /// Peut créer un retour sur une entrée de type autre que RDV
        /// </summary>
        CREATE_OTHER_FEEDBACK,

        /// <summary>
        /// Peut lire un retour sur une entrée de type autre que RDV
        /// </summary>
        READ_OTHER_FEEDBACK,

        /// <summary>
        /// Peut modifier un retour sur une entrée de type autre que RDV
        /// </summary>
        WRITE_OTHER_FEEDBACK,

        /// <summary>
        /// Peut supprimer un retour sur une entrée de type autre que RDV
        /// </summary>
        DELETE_OTHER_FEEDBACK,

        /// <summary>
        /// Peut reporter un RDV
        /// </summary>
        POSTPONE_RDV,

        /// <summary>
        /// Peut lire les commentaires d’une entré.
        /// </summary>
        READ_COMMENT,

        /// <summary>
        /// Peut créer des commentaires pour une entrée. Peut aussi modifier / supprimer les commentaires dont il est l’auteur.
        /// </summary>
        WRITE_COMMENT,

        /// <summary>
        /// Permet d’accéder à la vue classique de l’agenda.
        /// </summary>
        CLASSIC_VIEW,

        /// <summary>
        /// Permet d’accéder à la vue de prise de RDV de l’agenda.
        /// </summary>
        RDV_SLOTS_VIEW,

        /// <summary>
        /// Permet de mettre à jour les contraintes du calendrier (heures, jour, nb rdv max, ...).
        /// </summary>
        UPDATE_CALENDAR_CONSTRAINT,

        /// <summary>
        /// Permet la mise à jour des catégories d'entrée liées au calendrier.
        /// </summary>
        UPDATE_CALENDAR_ENTRY_CATEGORIES,

        /// <summary>
        /// Permet à un utilisateur de mettre à jour les informations de son compte (y compris le mot de passe).
        /// </summary>
        CAN_UPDATE_ACCOUNT,

        /// <summary>
        /// Droit par défaut si le droit n'est pas connu par l'application
        /// </summary>
        UNKNOWN = 999
    }
}