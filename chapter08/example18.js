function(doc) {
    if (doc.lastName !== null && doc.famous) {
        emit(doc.lastName, null)
    }
}