class DocumentStore(object):
       
    def __init__(self, capacity):
        self._capacity = capacity
        self._documents = []

    @property
    def capacity(self):
        return self._capacity

    # Return a list containing all documents in the store
    # There should be no way to modify the list returned by this method
    @property
    def documents(self):
        for i in range(len(self._documents)):
            self._documents.append(self._documents[i])
            
        return self._documents

    # Add a new document to the store 
    # If the document store is full, an exception should be raised
    def add_document(self, document):
        if(len(self._documents) > self._capacity):
            raise Exception("Document store is full") 
        else:
            self._documents.append(document)
            return self._documents
    
    def __repr__(self):
        #return "Document store: " + getsizeof(self._documents) + "/" + self._capacity
        return "Placeholder" 

#To see the output, uncomment the lines belows:
document_store = DocumentStore(2)
document_store.add_document("document")
print(document_store)