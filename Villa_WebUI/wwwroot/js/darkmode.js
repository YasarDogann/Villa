// Sayfa yüklendiğinde, localStorage'dan dark mode bilgisini kontrol et
window.onload = function() {
    const darkModeEnabled = localStorage.getItem('darkMode') === 'true';
    const body = document.getElementById('body');
    const button = document.getElementById('toggleButton');

    if (darkModeEnabled) {
        body.classList.add('dark-mode');
        button.innerText = 'Light Mode';
    } else {
        button.innerText = 'Dark Mode';
    }
};

// Dark Mode toggle fonksiyonu
function toggleDarkMode() {
    const body = document.getElementById('body');
    const button = document.getElementById('toggleButton');

    body.classList.toggle('dark-mode');

    // Dark mode aktifse, butonun metnini Light Mode olarak değiştir
    if (body.classList.contains('dark-mode')) {
        button.innerText = 'Light Mode';
        localStorage.setItem('darkMode', 'true'); // Dark mode'u localStorage'da kaydet
    } else {
        button.innerText = 'Dark Mode';
        localStorage.setItem('darkMode', 'false'); // Dark mode'u kapat, localStorage'da güncelle
    }
}
