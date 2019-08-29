$(function () {
    
    var tags = new Bloodhound({
        datumTokenizer: function (d) { return Bloodhound.tokenizers.whitespace(d.value); },
        queryTokenizer: Bloodhound.tokenizers.whitespace,
        local: [
            { tag: 'dog', value: 'aaa' },
            { tag: 'cat', value: 'bbb' },
            { tag: 'fish', value: 'ccc' },
            { tag: 'catfish', value: 'ddd' },
            { tag: 'dogfish', value: 'eee' }
        ]
    });

    tags.initialize();
    
    // Write callback data to the screen when tags are added or removed in demo inputs
    var logCallbackDataToConsole = function (added, removed) {
        console.log('Tag Data: ' + (this.val() || null) + ', Added: ' + added + ', Removed: ' + removed + '\n');
    };

    // Create typeahead-enabled tag inputs
    $('.tag-input').tagInput({
        allowDuplicates: false,
        typeahead: true,
        typeaheadOptions: {
            highlight: true
        },
        typeaheadDatasetOptions: {
            display: function (d) { return d.value; },
            source: tags.ttAdapter()
        },
        onTagDataChanged: logCallbackDataToConsole
    });

    // Create basic tag inputs with no typeahead
    $('.tag-input-basic').tagInput({
        onTagDataChanged: logCallbackDataToConsole
    });
    
});
