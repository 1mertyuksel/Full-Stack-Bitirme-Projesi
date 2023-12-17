function submitContent() {
    var name = document.getElementById('name').value;
    var commentText = document.getElementById('comment').value;

    if (!commentText.trim()) {
        alert("Lütfen bir yorum girin.");
        return;
    }
    var comment = '<div class="comment-container">';
    comment += '<h3>' + name + '</h3>';
    comment += '<p class="comment-text">' + commentText + '</p>';
    comment += '</div>';

    // Yorum div'ine ekle
    var commentDiv = document.getElementById('commentList');
    commentDiv.innerHTML += comment;

    // Girdi alanlarını temizle
    document.getElementById('name').value = '';
    document.getElementById('comment').value = '';
}