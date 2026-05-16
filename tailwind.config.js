/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './Views/**/*.cshtml',
    './Controllers/**/*.cs',
    './wwwroot/js/**/*.js'
  ],
  theme: {
    extend: {
      fontFamily: {
        sans: ['Plus Jakarta Sans', 'ui-sans-serif', 'sans-serif']
      },
      colors: {
        brand: {
          50: '#eef9f4',
          100: '#d4f0e2',
          500: '#14b86a',
          600: '#0f9a58',
          700: '#0c7a46'
        }
      }
    }
  },
  plugins: []
};
