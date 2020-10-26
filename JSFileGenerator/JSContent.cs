namespace JSFileGenerator
{
    partial class Program
    {
        public static class JSContent
        {
            public static string PrepareForFirestoreCrud()
            {
                return @"function prepareForFirestoreCrud(firestoreObj, collName, data, skipDataValidation = false) {

    if (!firestoreObj || firestoreObj == undefined || firestoreObj == null) {
        console.error('Initialize the Firestore Object before performing CRUD!');
        return false;
    }

    else if (collName == null || collName.trim() == '') {
        console.error('Collection name cannot be empty!');
        return false;
    }

    else if (typeof data != 'object' || data == undefined || data == null) {
        if (!skipDataValidation)
                {
                    console.error('Data cannot be empty and data should be an object.');
                    return false;
                }
            }

    else {
        return true;
    }
}";
            }

            public static string FirestoreCreateCode()
            {
                return @"function firestoreCreate(firestoreObj, collName, docName = null, data) {
    if (prepareForFirestoreCRUD(firestoreObj, collName, data)) {
        if (docName == null || docName.trim() == '') {
            return firestoreObj.collection(collName).add(docData);
        } else {
            return firestoreObj.collection(collName).doc(docName).set(docData);
        }
    }    
}";
            }

            public static string FirestoreUpdateCode()
            {
                return @"
function firestoreUpdate(firestoreObj, collName, docName, data) {
    if (prepareForFirestoreCRUD(firestoreObj, collName, data)) {
        if (docName == null || docName.trim() == '') {
            console.error('Document name cannot be empty to perform Firestore Update!');
        } else {
            return firestoreObj.collection(collName).doc(docName).update(docData);
        }
    }
}
";
            }

            public static string FirestoreDeleteCode()
            {
                return @"function firestoreDelete(firestoreObj, collName, docName) {
    if (prepareForFirestoreCRUD(firestoreObj, collName, null, true)) {
        if (docName == null || docName.trim() == '') {
            console.error('Document name cannot be empty to perform Firestore Delete!');
        } else {
            return firestoreObj.collection(collName).doc(docName).delete();
        }
    }
}
";
            }

            public static string FirestoreReadMultipleCode()
            {
                return @"function firestoreReadMultiple(firestoreObj, collName) {
    if (prepareForFirestoreCRUD(firestoreObj, collName, null, true)) {
        return firestoreObj.collection(collName).get();            
    }
}";
            }

            public static string FirestoreReadSingleCode()
            {
                return @"function firestoreReadSingle(firestoreObj, collName, docName) {
    if (prepareForFirestoreCRUD(firestoreObj, collName, null, true)) {
        if (docName == null || docName.trim() == '') {
            console.error('Document name cannot be empty to perform Firestore Query on single document!');
        } else {
            return firestoreObj.collection(collName).doc(docName).get();
        }
    }
}
";
            }

            public static string StartupHtml(string scriptFileName)
            {
                return "<!DOCTYPE html>\n" +
                    "<html lang=\"en\">\n" +
                    "<head>\n" +
                    "<meta charset=\"UTF - 8\">\n" +
                    "<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0\">\n" +
                    "<title>Document</title>\n" +
                    "</head>\n" +
                    "<body>\n" +
                    "<script src=\"" + scriptFileName + "\"></script>\n" +
                    "</body>\n" +
                    "</html>\n";
            }
        }
    }
}
